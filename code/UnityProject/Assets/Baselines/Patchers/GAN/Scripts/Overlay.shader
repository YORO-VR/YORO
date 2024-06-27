Shader "Hidden/Overlay"
{
    Properties
    {
        _BaseTex ("Texture", 2D) = "white" {}
        _OverlayTex ("Texture", 2D) = "white" {}
        _MaskTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _BaseTex;
            sampler2D _OverlayTex;
            sampler2D _MaskTex;

            float4 frag(v2f i) : SV_Target
            {
                float4 mask = tex2D(_MaskTex, i.uv);
                return mask.r == 0 ? tex2D(_OverlayTex, i.uv) : tex2D(_BaseTex, i.uv);
            }
            ENDCG
        }
    }
}
