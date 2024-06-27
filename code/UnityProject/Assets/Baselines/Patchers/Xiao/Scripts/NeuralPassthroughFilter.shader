Shader "Hidden/NeuralPassthroughFilter" {
    Properties{
        _MainTex("Base (RGB)", 2D) = "white" {}
    }
    SubShader{
        Pass {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"
            uniform sampler2D _MainTex;
            uniform sampler2D _CameraDepthTexture;
            float width;

            float4 frag(v2f_img id) : COLOR {
                half4 o = tex2D(_MainTex, id.uv);

                if (o.w > 0 || o.g == 0) return float4(o.rgb, 1);

                float d_min = 1;
                float d_max = 0;
                half4 c_acc = 0;
                float w_acc = 0;

                UNITY_LOOP
                for (int dx = -14; dx < 15; dx++) {
                    for (int dy = -14; dy < 15; dy++) {
                        half2 _uv = id.uv + half2(dx, dy) * width; 
                        float d = tex2D(_MainTex, _uv).w;
                        if (d > 0.01f) {
                            d_min = min(d_min, d);
                            d_max = max(d_max, d);
                        }
                    }
                }

                float thresh = 0.5f * (d_min + d_max);
                UNITY_LOOP
                for (int dx = -14; dx < 15; dx++) {
                    for (int dy = -14; dy < 15; dy++) {
                        half2 _uv = id.uv + half2(dx, dy) * width;
                        float d = tex2D(_MainTex, _uv).w;
                        if (d > 0.01f && d < thresh) {
                            float w = 36 * ((d - d_min) / (d_max - d_min) + 1.0f / 9);
                            c_acc += tex2D(_MainTex, _uv) * w;
                            w_acc += w;
                        }
                    }
                }

                return w_acc > 0 ? float4((c_acc / w_acc).rgb, 1) : 0;
            }
            ENDCG
        }
    }
}