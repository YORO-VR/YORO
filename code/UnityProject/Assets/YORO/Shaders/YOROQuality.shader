Shader "Hidden/YOROQuality" {
    Properties{
        _MainTex("Base (RGB)", 2D) = "white" {}
    }
    SubShader{
        Pass { // 0
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"
            uniform sampler2D _MainTex;
            sampler2D  _CameraDepthTexture;
            float4x4 output_vp;
            float4x4 input_vp_inverse;

            float2  frag(v2f_img id) : SV_TARGET{
                float depth = tex2D(_CameraDepthTexture, id.uv);
                id.uv = id.uv - float2(0.00099f, 0.00099f); // Fix uv error from Image Shader.
                float4 _proj = float4(id.uv * 2 - 1, depth, 1);
                float4 proj = mul(output_vp, mul(input_vp_inverse, _proj));
                float shift = ((proj.x + 1) * 0.5);
                return float2(shift,proj.z);
            }
            ENDCG
        }

        Pass { // 1
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"
            uniform sampler2D _MainTex;
            float width;

            float4 frag(v2f_img id) : COLOR {
                half4 o = tex2D(_MainTex, id.uv);

                if (o.w != 0) return o;
                half info = o.x;
                float gap_width = min(10.0f, o.z * width);

                half4 color = half4(0, 0, 0, 1);
                int dir = info > 0 ? 1 : -1;
                half step = dir / width;
                half2 startUV = half2(info * dir, id.uv.y);
                half remain_weight = 1;
                half bias = 0.5f + 0.3f * (id.uv.x - startUV.x) / o.z;

                for (int i = 0; i < gap_width; i++) {
                    half xx = i * step;
                    half2 _uv = startUV + half2(xx, 0);
                    half4 c = tex2D(_MainTex, _uv);
                    if (c.w != 0 && (c.w - 0.0001f < o.y || remain_weight == 1)) {
                        half w = bias * remain_weight;
                        color += c * w;
                        remain_weight -= w;
                    }
                }

                color /= (1 - remain_weight);
                return float4(color.xyz,1);
            }
            ENDCG
        }
    }
}