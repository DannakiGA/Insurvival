Shader "DonakiShaders/Decal"
{
    Properties{
    _Color("Main Color", Color) = (1,1,1,1)
    _MainTex("Base (RGB)", 2D) = "white" {}
    _CubeTex("Cubemap", cube) = "" {}
    _Illum("Illumin (A)", 2D) = "white" {}
    _ReflectColor("Reflection Color", Color) = (1,1,1,0.5)

    }
        SubShader{
            Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
            LOD 100

        CGPROGRAM
        #pragma surface surf Lambert alpha:fade

        sampler2D _MainTex;
        sampler2D _Illum;
        samplerCUBE _CubeTex;
        fixed4 _Color;
        fixed4 _ReflectColor;

        struct Input {
            float2 uv_MainTex;
            float2 uv_Illum;
            float3 worldRefl;
            float2 uv_DecalTex;
        };

        void surf(Input IN, inout SurfaceOutput o) {
            fixed4 tex = tex2D(_MainTex, IN.uv_MainTex) *_Color;
            o.Albedo = tex.rgb;
            o.Alpha = tex.a;

            fixed4 reflcol = texCUBE(_CubeTex, IN.worldRefl);
            reflcol *= tex.a;
            o.Emission = reflcol.rgb * tex2D(_Illum, IN.uv_Illum).a;
            o.Alpha = tex.a;
        }
        ENDCG
    }
}
