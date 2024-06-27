using System.Collections.Generic;
using OpenCVForUnity;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;
using UnityEngine.UI;
using UnityEngine.XR;

public class PatcherTelea : MonoBehaviour {
    public ComputeShader yoro;

    private Camera camera;

    private RenderTexture
        pixel_shift,
        reprojected,
        mask;

    private int width, height;

    private int reprojectHandle;

    private Material yoro_mat;
    private XRDisplaySubsystem xr_display;
    public int resolution = 1024;


    void Start() {
        camera = GetComponent<Camera>();
        var displaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displaySubsystems);
        xr_display = displaySubsystems[0];

        Unity.XR.MockHMD.MockHMD.SetEyeResolution(resolution, resolution);
        width = resolution;
        height = resolution;
        yoro_mat = new Material(Shader.Find("Hidden/YOROQuality"));

        InitTextures();
        InitShader();

        camera.depthTextureMode = DepthTextureMode.Depth;
    }

    private void InitTextures() {
        pixel_shift = new RenderTexture(width, height, 0, RenderTextureFormat.RGHalf, RenderTextureReadWrite.Linear);
        pixel_shift.Create();

        reprojected =
            new RenderTexture(width, height, 0, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
        reprojected.enableRandomWrite = true;
        reprojected.filterMode = FilterMode.Point;
        reprojected.Create();

        mask =
            new RenderTexture(width, height, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
        mask.enableRandomWrite = true;
        mask.filterMode = FilterMode.Point;
        mask.Create();
    }

    private void InitShader() {
        reprojectHandle = yoro.FindKernel("Reprojector");
        yoro.SetTexture(reprojectHandle, "output", reprojected);
        yoro.SetTexture(reprojectHandle, "output_mask", mask);
        yoro.SetTexture(reprojectHandle, "shift_buffer", pixel_shift);
        yoro.SetFloat("tex_width", width);
    }

    
    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        var input_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Right);
        var target_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Left);

        yoro_mat.SetMatrix("output_vp", target_vp);
        yoro_mat.SetMatrix("input_vp_inverse", input_vp.inverse);
        
        Graphics.Blit(pixel_shift, pixel_shift, yoro_mat, 0); //Shift Texture

        ClearRenderTexture(reprojected);
        ClearRenderTexture(mask);
        yoro.SetTexture(reprojectHandle, "rgb_buffer", source);
        yoro.Dispatch(reprojectHandle, 1, height / 64, 1); // Reprojected RGB

        Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(1));
        Patch(reprojected, xr_display.GetRenderTextureForRenderPass(0), mask);
    }

    public void ClearRenderTexture(RenderTexture renderTexture) {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = renderTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }

    private Texture2D src_texture, mask_texture, texture;

    public void Patch(RenderTexture source, RenderTexture outputTex, RenderTexture outputMaskInverse) {
        if (src_texture == null) {
            src_texture = new Texture2D(outputTex.width, outputTex.height, TextureFormat.ARGB32, false);
            mask_texture = new Texture2D(outputMaskInverse.width, outputMaskInverse.height, TextureFormat.ARGB32, false);
            texture = new Texture2D(outputMaskInverse.width, outputMaskInverse.height, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None);
        }

        Utils.textureToTexture2D(source, src_texture);
        Mat srcMat = new Mat(src_texture.height, src_texture.width, CvType.CV_8UC3);

        Utils.texture2DToMat(src_texture, srcMat);

        Utils.textureToTexture2D(outputMaskInverse, mask_texture);
        Mat maskMat = new Mat(mask_texture.height, mask_texture.width, CvType.CV_8UC1);

        Utils.texture2DToMat(mask_texture, maskMat);

        Mat dstMat = new Mat(srcMat.rows(), srcMat.cols(), CvType.CV_8UC3);
        Photo.inpaint(srcMat, maskMat, dstMat, 3, Photo.INPAINT_TELEA);
        Utils.matToTexture2D(dstMat, texture);

        srcMat.release();
        maskMat.release();
        dstMat.release();
        Graphics.Blit(texture, outputTex);
    }
}
