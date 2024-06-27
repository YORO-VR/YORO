Shader "Hidden/YOROPerformance" {
    Properties{
        _MainTex("Texture", 2D) = "white" {}
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

            half2  frag(v2f_img id) : SV_TARGET{
                half depth = tex2D(_CameraDepthTexture, id.uv);
                id.uv = id.uv - float2(0.00099f, 0.00099f); // Fix uv error from Image Shader.
                half4 _proj = half4(id.uv * 2 - 1, depth, 1);
                half4 proj = mul(output_vp, mul(input_vp_inverse, _proj));
                half shift = ((proj.x + 1) * 0.5);
                return half2(shift, proj.z);
            }
            ENDCG
        }

        Pass { // 1
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"
            uniform sampler2D _MainTex;
            sampler2D _Map;

            half4  frag(v2f_img id) : SV_TARGET{
                half pos_x = tex2D(_Map, id.uv);
                half2 new_uv = half2(pos_x, id.uv.y);
                return tex2D(_MainTex, new_uv);
            }
            ENDCG
        }

        Pass { // 2
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"
            uniform sampler2D _MainTex;
            sampler2D _Map;
            float width;

            float4 frag(v2f_img id) : COLOR {
                half4 info = tex2D(_Map, id.uv);

                if (info.w == 1) {
                    half2 new_uv = half2(info.x, id.uv.y);
                    return tex2D(_MainTex, new_uv);
                }

                half start_shift = info.x;
                int dir = start_shift > id.uv.x ? 1 : -1;
                half step = dir / width;
                half2 startUV = half2(id.uv.x, id.uv.y);
                half bias = 0.5f + 0.3f * info.y / info.z;
                float gap_width = min(10.0f, info.z * width);

                half remain_weight = 1;
                half4 color = half4(0, 0, 0, 1);
                for (int i = 0; i < gap_width; i++) {
                    half xx = i * step;
                    half2 _uv = startUV + half2(xx, 0);
                    half4 _info = tex2D(_Map, _uv);

                    half2 new_uv = half2(_info.x, id.uv.y);
                    half4 c = tex2D(_MainTex, new_uv);

                    half w = bias * remain_weight;
                    color += c * w;
                    remain_weight -= w;
                }

                color /= (1 - remain_weight);
                return float4(color.xyz,1);
            }
            ENDCG
        }

    }
}