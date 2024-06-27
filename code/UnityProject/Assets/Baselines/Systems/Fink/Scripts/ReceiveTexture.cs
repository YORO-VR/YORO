using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

[ExecuteInEditMode]
public class ReceiveTexture : MonoBehaviour {
    public RenderTexture Texture;

    void Start() {
        Texture = null;
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination) {
        if (Texture == null) {
            Texture = new RenderTexture(source.width, source.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
            Texture.depthStencilFormat = GraphicsFormat.D24_UNorm_S8_UInt;
        }
        Graphics.Blit(source, Texture);
        Graphics.Blit(source, destination);
    }
}
