using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.XR;

public enum YOROMode {
    Quality,
    Performance,
}

public enum YOROScale {
    Half       = 2,
    Quarter    = 4,
    Eighth     = 8,
    OneSixteen = 16,
}

public enum YOROPerformancePatcher {
    YORO,
    Sample,
}

[RequireComponent(typeof(Camera))]
public class YORO : MonoBehaviour {
    public ComputeShader YOROComputeShader;
    public Shader YOROPerformanceShader;
    public Shader YOROQualityShader;
    public YOROMode Mode = YOROMode.Quality;
    public YOROScale ReprojectionScale = YOROScale.Half;
    public YOROPerformancePatcher Patcher = YOROPerformancePatcher.YORO;

    private YOROScale _lastReprojectionScale;
    private YOROPerformancePatcher _lastPatcher;
    private Camera camera;

    private RenderTexture
        _fullPixelShift,
        _reprojected;

    private RenderTexture
        _intermediatePixelShift,
        _mappedShift;

    private int _width, _height, _intermediateWidth, _intermediateHeight;

    private int reprojectHandle, mapperHandle;

    private Material _YOROPerformanceMat, _YOROQualityMat;
    private XRDisplaySubsystem xr_display;
    private bool _initedQuality, _initedPerformance;


    void Start() {
        camera = GetComponent<Camera>();
        var displaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displaySubsystems);
        xr_display = displaySubsystems[0];
        
        _YOROPerformanceMat = new Material(YOROPerformanceShader);
        _YOROQualityMat = new Material(YOROQualityShader);

        camera.depthTextureMode = DepthTextureMode.Depth;
        camera.stereoTargetEye = StereoTargetEyeMask.Right;
        XRSettings.eyeTextureResolutionScale = 0.67f;
        _lastReprojectionScale = ReprojectionScale;
        _lastPatcher = Patcher;
    }

    void Update() {
        if (Mode != YOROMode.Performance) return;
        if (ReprojectionScale != _lastReprojectionScale) {
            _lastReprojectionScale = ReprojectionScale;
            OnReprojectionScaleChange();
        }

        if (Patcher != _lastPatcher) {
            _lastPatcher = Patcher;
            OnPatcherChange();
        }
    }

    private void InitTexturesQuality() {
        _fullPixelShift = new RenderTexture(_width, _height, 0, RenderTextureFormat.RGFloat, RenderTextureReadWrite.Linear);
        _fullPixelShift.Create();

        _reprojected =
            new RenderTexture(_width, _height, 0, RenderTextureFormat.ARGBFloat, RenderTextureReadWrite.Linear);
        _reprojected.enableRandomWrite = true;
        _reprojected.filterMode = FilterMode.Point;
        _reprojected.Create();
    }

    private void InitTexturePerformance() {
        _intermediatePixelShift = new RenderTexture(_intermediateWidth, _intermediateHeight, 0,
            RenderTextureFormat.RGHalf, RenderTextureReadWrite.Linear);
        _intermediatePixelShift.depthStencilFormat = GraphicsFormat.None;
        _intermediatePixelShift.name = "reducedPixelShift";
        _intermediatePixelShift.Create();

        if (Patcher == YOROPerformancePatcher.Sample) {
            _mappedShift =
                new RenderTexture(_intermediateWidth, _intermediateHeight, 0, 
                    RenderTextureFormat.RGHalf, RenderTextureReadWrite.Linear);
        }
        else {
            _mappedShift =
                new RenderTexture(_intermediateWidth, _intermediateHeight, 0, 
                    RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
        }

        _mappedShift.depthStencilFormat = GraphicsFormat.None;
        _mappedShift.enableRandomWrite = true;
        _mappedShift.Create();
    }

    private void InitMaterialQuality() {
        reprojectHandle = YOROComputeShader.FindKernel("ReprojectorQuality");
        YOROComputeShader.SetTexture(reprojectHandle, "output_rgb", _reprojected);
        YOROComputeShader.SetTexture(reprojectHandle, "shift_buffer", _fullPixelShift);
        YOROComputeShader.SetFloat("tex_width", _width);

        _YOROQualityMat.SetFloat("width", _width);
    }

    private void InitMaterialPerformance() {
        mapperHandle = YOROComputeShader.FindKernel(Patcher == YOROPerformancePatcher.Sample 
            ? "ReprojectorPerformance" 
            : "ReprojectorPerformanceWithPatcher");
        YOROComputeShader.SetTexture(mapperHandle, 
            Patcher == YOROPerformancePatcher.Sample ? "output_shift" : "output_shift_with_patcher", _mappedShift);
        YOROComputeShader.SetTexture(mapperHandle, "shift_buffer", _intermediatePixelShift);
        YOROComputeShader.SetFloat("tex_width_reduced", _intermediateWidth);

        _YOROPerformanceMat.SetTexture("_Map", _mappedShift);
        _YOROPerformanceMat.SetFloat("width", _width);
    }

    private void InitYOROQuality(int width, int height) {
        _width = width;
        _height = height;
        InitTexturesQuality();
        InitMaterialQuality();
    }

    private void InitYOROPerformance(int width, int height) {
        _width = width;
        _height = height;
        var scale = 1.0f / (int)ReprojectionScale;
        _intermediateWidth = (int)(width * scale);
        _intermediateHeight = (int)(height * scale);
        InitTexturePerformance();
        InitMaterialPerformance();
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        if (!xr_display.running) return;
        if (Mode == YOROMode.Quality && !_initedQuality) {
            InitYOROQuality(source.width, source.height);
            _initedQuality = true;
        }

        if (Mode == YOROMode.Performance && !_initedPerformance) {
            InitYOROPerformance(source.width, source.height);
            _initedPerformance = true;
        }
        if (Mode == YOROMode.Quality) RenderYOROQuality(source);
        if (Mode == YOROMode.Performance) RenderYOROPerformance(source);
    }

    private void RenderYOROQuality(RenderTexture source) {
        var input_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Right);
        var target_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Left);

        _YOROQualityMat.SetMatrix("output_vp", target_vp);
        _YOROQualityMat.SetMatrix("input_vp_inverse", input_vp.inverse);

        Graphics.Blit(_fullPixelShift, _fullPixelShift, _YOROQualityMat, 0); //Shift Texture

        ClearRenderTexture(_reprojected);
        YOROComputeShader.SetTexture(reprojectHandle, "rgb_buffer", source);
        YOROComputeShader.Dispatch(reprojectHandle, 1, _height / 64, 1); // Reprojected RGB

        Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(1));
        Graphics.Blit(_reprojected, xr_display.GetRenderTextureForRenderPass(0), _YOROQualityMat, 1);
    }

    private void RenderYOROPerformance(RenderTexture source) {
        var input_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Right);
        var target_vp =
            GL.GetGPUProjectionMatrix(camera.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left), false)
            * camera.GetStereoViewMatrix(Camera.StereoscopicEye.Left);

        _YOROPerformanceMat.SetMatrix("output_vp", target_vp);
        _YOROPerformanceMat.SetMatrix("input_vp_inverse", input_vp.inverse);

        Graphics.Blit(_intermediatePixelShift, _intermediatePixelShift, _YOROPerformanceMat, 0); //Shift Texture

        ClearRenderTexture(_mappedShift);

        var groupY = (int)Math.Ceiling(_intermediateHeight / 64.0f);
        YOROComputeShader.Dispatch(mapperHandle, 1, groupY,  1); // Reprojected shift

        Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(1));
        Graphics.Blit(source, xr_display.GetRenderTextureForRenderPass(0), _YOROPerformanceMat, 
            Patcher == YOROPerformancePatcher.Sample ? 1 : 2);
    }

    public void OnReprojectionScaleChange() {
        _intermediatePixelShift.Release();
        _mappedShift.Release();
        InitYOROPerformance(_width, _height);
    }

    public void OnPatcherChange() {
        _intermediatePixelShift.Release();
        _mappedShift.Release();
        InitYOROPerformance(_width, _height);
    }

    public void ReleaseRenderTextures() {
        _fullPixelShift?.Release();
        _reprojected?.Release();
        _intermediatePixelShift?.Release();
        _mappedShift?.Release();
        _fullPixelShift = _reprojected = _intermediatePixelShift = _mappedShift = null;
    }

    public void ClearRenderTexture(RenderTexture renderTexture) {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = renderTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }
}

