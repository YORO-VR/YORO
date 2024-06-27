using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlitTexture : MonoBehaviour {
    public ReceiveTexture Source;
    // Start is called before the first frame update
    void OnRenderImage(RenderTexture source, RenderTexture destination) {
        Graphics.Blit(Source.Texture, destination);
    }
}
