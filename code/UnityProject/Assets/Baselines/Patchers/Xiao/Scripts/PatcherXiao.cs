using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;
using UnityEngine.XR;

public class PatcherXiao : MonoBehaviour
{
    public ComputeShader yoro;

    private Camera camera;

    private RenderTexture
        pixel_shift,
        reprojected;

    private int width, height;

    private int reprojectHandle;

    private Material yoro_mat, patch_mat;
    private XRDisplaySubsystem xr_display;
    public int resolution = 1024;


    void Start()
    {
        camera = GetComponent<Camera>();
        var displaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displaySubsystems);
        xr_display = displaySubsystems[0];

        Unity.XR.MockHMD.MockHMD.SetEyeResolution(resolution, resolution);
        width = resolution;
        height = resolution;
        yoro_mat = new Material(Shader.Find("Hidden/YOROQuality"));
        patch_mat = new Material(Shader.Find("Hidden/NeuralPassthroughFilter"));

        InitTextures();
        InitShader();

        camera.depthTextureMode = DepthTextureMode.Depth;
    }

    private void InitTextures()
    { 
        pixel_shift = new RenderTexture(width, height, 0, RenderTextureFormat.RGHalf, RenderTextureReadWrite.Linear);
        pixel_shift.Create();

        reprojected =
            new RenderTexture(width, height, 0, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
        reprojected.enableRandomWrite = true;
        reprojected.filterMode = FilterMode.Point;
        reprojected.Create();
    }

    private void InitShader()
    {
        reprojectHandle = yoro.FindKernel("Reprojector");
        yoro.SetTexture(reprojectHandle, "output", reprojected);
        yoro.SetTexture(reprojectHandle, "shift_buffer", pixel_shift);
        yoro.SetFloat("tex_width", width);

        patch_mat.SetFloat("width", 1.0f/width);
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
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
        yoro.SetTexture(reprojectHandle, "rgb_buffer", source);
        yoro.Dispatch(reprojectHandle, 1, height / 64, 1); // Reprojected RGB

        Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(1));
        Graphics.Blit(reprojected, xr_display.GetRenderTextureForRenderPass(0), patch_mat);
    }

    public void ClearRenderTexture(RenderTexture renderTexture)
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = renderTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }
}
