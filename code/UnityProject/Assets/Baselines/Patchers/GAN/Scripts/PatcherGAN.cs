using System.Collections.Generic;
using Unity.Barracuda;
using UnityEngine;
using UnityEngine.XR;

namespace YouOnlyRenderOnce.Release
{
    public class PatcherGAN : MonoBehaviour {
        public ComputeShader yoro;
        public NNModel Model;
        public Shader OverlayShader;
        private IWorker Worker;

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
        private Material _overlayMaterial;
        private Material OverlayMaterial {
            get {
                if (_overlayMaterial == null) _overlayMaterial = new Material(OverlayShader);
                return _overlayMaterial;
            }
        }


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

            OverlayMaterial.SetTexture("_BaseTex", reprojected);
            OverlayMaterial.SetTexture("_MaskTex", mask);
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
            yoro.SetTexture(reprojectHandle, "rgb_buffer", source);
            yoro.Dispatch(reprojectHandle, 1, height / 64, 1); // Reprojected RGB

            if (Worker == null) {
                var model = ModelLoader.Load(Model);
                Worker = WorkerFactory.CreateWorker(model, WorkerFactory.Device.GPU);
            }
            RenderTexture scaleDown =
                RenderTexture.GetTemporary(256, 256, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
            Graphics.Blit(reprojected, scaleDown);

            Tensor input = new Tensor(scaleDown, 4);
            Dictionary<string, Tensor> temp = new Dictionary<string, Tensor> { { "RGBD", input } };
            Worker.Execute(temp);
            Tensor o = Worker.PeekOutput();
            RenderTexture outputRT =
                RenderTexture.GetTemporary(256, 256, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
            o.ToRenderTexture(outputRT);

            RenderTexture scaleUp =
                RenderTexture.GetTemporary(width, height, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
            Graphics.Blit(outputRT, scaleUp);

            OverlayMaterial.SetTexture("_OverlayTex", scaleUp);

            Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(1));
            Graphics.Blit(scaleUp, xr_display.GetRenderTextureForRenderPass(0), OverlayMaterial);

            RenderTexture.ReleaseTemporary(scaleUp);
            RenderTexture.ReleaseTemporary(outputRT);
            RenderTexture.ReleaseTemporary(scaleDown);
        }

        public void ClearRenderTexture(RenderTexture renderTexture) {
            RenderTexture rt = RenderTexture.active;
            RenderTexture.active = renderTexture;
            GL.Clear(true, true, Color.clear);
            RenderTexture.active = rt;
        }
    }
}