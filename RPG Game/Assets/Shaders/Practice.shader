Shader "Custom/NewSurfaceShader"
{
    Properties
    {
        
        _myBump("Bump",2D)="bump"{}
        _myCube("Cube Map",CUBE)="white"{}
        _mySlider("Bump Amount",Range(0,1)) = 0.1
    }
        SubShader
        {

            CGPROGRAM
            #pragma surface surf Lambert

            half _mySlider;
            sampler2D _myBump;
            samplerCUBE _myCube;
        

        struct Input {
            float2 uv_myTex;
            float2 uv_myBump;
            float3 worldRefl; INTERNAL_DATA
        };

        void surf(Input IN, inout SurfaceOutput o) {
            o.Normal = UnpackNormal(tex2D(_myBump, IN.uv_myBump)) * _mySlider;
            o.Albedo = texCUBE(_myCube, WorldReflectionVector(IN, o.Normal)).rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
