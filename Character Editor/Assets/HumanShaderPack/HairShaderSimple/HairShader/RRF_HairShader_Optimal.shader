// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:True,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33833,y:32627,varname:node_2865,prsc:2|diff-8051-OUT,diffpow-4961-OUT,spec-7877-OUT,gloss-7779-A,normal-208-OUT,clip-8370-R;n:type:ShaderForge.SFN_Tex2d,id:5242,x:31993,y:32702,ptovrint:False,ptlb:NormalMap1,ptin:_NormalMap1,varname:node_5242,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:8706,x:31993,y:32888,ptovrint:False,ptlb:NormalMap2,ptin:_NormalMap2,varname:node_8706,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:8370,x:31993,y:33088,ptovrint:False,ptlb:Cutout/TipGrad1/TipGrad2,ptin:_CutoutTipGrad1TipGrad2,varname:node_8370,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:db53956d7bc64a542926b4d2aa7b036b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:7779,x:31993,y:32472,ptovrint:False,ptlb:Hair_Color/Gloss,ptin:_Hair_ColorGloss,varname:node_7779,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:7877,x:33403,y:32666,varname:node_7877,prsc:2|A-8051-OUT,B-1087-OUT;n:type:ShaderForge.SFN_Slider,id:1087,x:31679,y:32645,ptovrint:False,ptlb:SpecColor Inheritance,ptin:_SpecColorInheritance,varname:node_1087,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:5;n:type:ShaderForge.SFN_ViewVector,id:3033,x:32865,y:33584,varname:node_3033,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:6874,x:32876,y:33372,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:4961,x:33302,y:33420,varname:node_4961,prsc:2,dt:4|A-6874-OUT,B-3033-OUT;n:type:ShaderForge.SFN_NormalBlend,id:6912,x:32242,y:32799,varname:node_6912,prsc:2|BSE-5242-RGB,DTL-8706-RGB;n:type:ShaderForge.SFN_Lerp,id:8201,x:32495,y:33018,varname:node_8201,prsc:2|A-7779-RGB,B-9661-OUT,T-4546-OUT;n:type:ShaderForge.SFN_Color,id:1983,x:31993,y:33267,ptovrint:False,ptlb:Grad1_Color,ptin:_Grad1_Color,varname:node_1983,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:9661,x:32350,y:33147,varname:node_9661,prsc:2|A-4546-OUT,B-1983-RGB;n:type:ShaderForge.SFN_Color,id:4505,x:31993,y:33443,ptovrint:False,ptlb:Grad2_Color,ptin:_Grad2_Color,varname:node_4505,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.5,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:9615,x:32439,y:33400,varname:node_9615,prsc:2|A-3215-OUT,B-4505-RGB;n:type:ShaderForge.SFN_Lerp,id:3241,x:32717,y:33097,varname:node_3241,prsc:2|A-8201-OUT,B-9615-OUT,T-3215-OUT;n:type:ShaderForge.SFN_Slider,id:878,x:31702,y:33394,ptovrint:False,ptlb:Grad2_Power,ptin:_Grad2_Power,varname:node_878,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.446602,max:1;n:type:ShaderForge.SFN_Multiply,id:3215,x:32210,y:33296,varname:node_3215,prsc:2|A-8370-B,B-878-OUT;n:type:ShaderForge.SFN_Slider,id:9632,x:31610,y:33114,ptovrint:False,ptlb:Grad1_Power,ptin:_Grad1_Power,varname:_Grad2_Power_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:4546,x:32171,y:33147,varname:node_4546,prsc:2|A-8370-G,B-9632-OUT;n:type:ShaderForge.SFN_Normalize,id:7103,x:33065,y:32767,varname:node_7103,prsc:2|IN-7485-OUT;n:type:ShaderForge.SFN_Vector3,id:6285,x:32489,y:32639,varname:node_6285,prsc:2,v1:0,v2:0,v3:0.5;n:type:ShaderForge.SFN_Lerp,id:7485,x:32664,y:32683,varname:node_7485,prsc:2|A-6285-OUT,B-6912-OUT,T-388-OUT;n:type:ShaderForge.SFN_Slider,id:388,x:32242,y:32735,ptovrint:False,ptlb:Normal_Blending,ptin:_Normal_Blending,varname:node_388,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_NormalVector,id:2397,x:32273,y:32172,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:1387,x:32853,y:32407,varname:node_1387,prsc:2|A-4633-OUT,B-1983-RGB,C-9632-OUT;n:type:ShaderForge.SFN_Add,id:8051,x:33144,y:32555,varname:node_8051,prsc:2|A-1387-OUT,B-3241-OUT;n:type:ShaderForge.SFN_NormalVector,id:3067,x:33093,y:32981,prsc:2,pt:False;n:type:ShaderForge.SFN_NormalBlend,id:208,x:33599,y:32808,varname:node_208,prsc:2|BSE-7103-OUT,DTL-2237-OUT;n:type:ShaderForge.SFN_Add,id:2237,x:33375,y:33016,varname:node_2237,prsc:2|A-3067-OUT,B-3418-G;n:type:ShaderForge.SFN_Color,id:3418,x:33093,y:33168,ptovrint:False,ptlb:Normal Angle Shift,ptin:_NormalAngleShift,varname:node_3418,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_LightVector,id:1595,x:32273,y:32356,varname:node_1595,prsc:2;n:type:ShaderForge.SFN_Dot,id:4633,x:32481,y:32234,varname:node_4633,prsc:2,dt:0|A-2397-OUT,B-1595-OUT;proporder:7779-1087-8370-5242-8706-1983-9632-4505-878-388-3418;pass:END;sub:END;*/

Shader "RRF_HumanShaders/HairShader1/RRF_HairShader_Optimal" {
    Properties {
        _Hair_ColorGloss ("Hair_Color/Gloss", Color) = (0.5,0.5,0.5,1)
        _SpecColorInheritance ("SpecColor Inheritance", Range(-1, 5)) = 0
        _CutoutTipGrad1TipGrad2 ("Cutout/TipGrad1/TipGrad2", 2D) = "white" {}
        _NormalMap1 ("NormalMap1", 2D) = "bump" {}
        _NormalMap2 ("NormalMap2", 2D) = "bump" {}
        _Grad1_Color ("Grad1_Color", Color) = (1,0,0,1)
        _Grad1_Power ("Grad1_Power", Range(0, 1)) = 1
        _Grad2_Color ("Grad2_Color", Color) = (0,0.5,1,1)
        _Grad2_Power ("Grad2_Power", Range(0, 1)) = 0.446602
        _Normal_Blending ("Normal_Blending", Range(0, 1)) = 0.5
        _NormalAngleShift ("Normal Angle Shift", Color) = (0.5,0.5,0.5,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _NormalMap1; uniform float4 _NormalMap1_ST;
            uniform sampler2D _NormalMap2; uniform float4 _NormalMap2_ST;
            uniform sampler2D _CutoutTipGrad1TipGrad2; uniform float4 _CutoutTipGrad1TipGrad2_ST;
            uniform float4 _Hair_ColorGloss;
            uniform float _SpecColorInheritance;
            uniform float4 _Grad1_Color;
            uniform float4 _Grad2_Color;
            uniform float _Grad2_Power;
            uniform float _Grad1_Power;
            uniform float _Normal_Blending;
            uniform float4 _NormalAngleShift;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap1_var = UnpackNormal(tex2D(_NormalMap1,TRANSFORM_TEX(i.uv0, _NormalMap1)));
                float3 _NormalMap2_var = UnpackNormal(tex2D(_NormalMap2,TRANSFORM_TEX(i.uv0, _NormalMap2)));
                float3 node_6912_nrm_base = _NormalMap1_var.rgb + float3(0,0,1);
                float3 node_6912_nrm_detail = _NormalMap2_var.rgb * float3(-1,-1,1);
                float3 node_6912_nrm_combined = node_6912_nrm_base*dot(node_6912_nrm_base, node_6912_nrm_detail)/node_6912_nrm_base.z - node_6912_nrm_detail;
                float3 node_6912 = node_6912_nrm_combined;
                float3 node_208_nrm_base = normalize(lerp(float3(0,0,0.5),node_6912,_Normal_Blending)) + float3(0,0,1);
                float3 node_208_nrm_detail = (i.normalDir+_NormalAngleShift.g) * float3(-1,-1,1);
                float3 node_208_nrm_combined = node_208_nrm_base*dot(node_208_nrm_base, node_208_nrm_detail)/node_208_nrm_base.z - node_208_nrm_detail;
                float3 node_208 = node_208_nrm_combined;
                float3 normalLocal = node_208;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 _CutoutTipGrad1TipGrad2_var = tex2D(_CutoutTipGrad1TipGrad2,TRANSFORM_TEX(i.uv0, _CutoutTipGrad1TipGrad2));
                clip(_CutoutTipGrad1TipGrad2_var.r - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Hair_ColorGloss.a;
                float perceptualRoughness = 1.0 - _Hair_ColorGloss.a;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_4546 = (_CutoutTipGrad1TipGrad2_var.g*_Grad1_Power);
                float node_3215 = (_CutoutTipGrad1TipGrad2_var.b*_Grad2_Power);
                float3 node_8051 = ((dot(i.normalDir,lightDirection)*_Grad1_Color.rgb*_Grad1_Power)+lerp(lerp(_Hair_ColorGloss.rgb,(node_4546*_Grad1_Color.rgb),node_4546),(node_3215*_Grad2_Color.rgb),node_3215));
                float3 specularColor = (node_8051*_SpecColorInheritance);
                float specularMonochrome;
                float3 diffuseColor = node_8051; // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _NormalMap1; uniform float4 _NormalMap1_ST;
            uniform sampler2D _NormalMap2; uniform float4 _NormalMap2_ST;
            uniform sampler2D _CutoutTipGrad1TipGrad2; uniform float4 _CutoutTipGrad1TipGrad2_ST;
            uniform float4 _Hair_ColorGloss;
            uniform float _SpecColorInheritance;
            uniform float4 _Grad1_Color;
            uniform float4 _Grad2_Color;
            uniform float _Grad2_Power;
            uniform float _Grad1_Power;
            uniform float _Normal_Blending;
            uniform float4 _NormalAngleShift;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap1_var = UnpackNormal(tex2D(_NormalMap1,TRANSFORM_TEX(i.uv0, _NormalMap1)));
                float3 _NormalMap2_var = UnpackNormal(tex2D(_NormalMap2,TRANSFORM_TEX(i.uv0, _NormalMap2)));
                float3 node_6912_nrm_base = _NormalMap1_var.rgb + float3(0,0,1);
                float3 node_6912_nrm_detail = _NormalMap2_var.rgb * float3(-1,-1,1);
                float3 node_6912_nrm_combined = node_6912_nrm_base*dot(node_6912_nrm_base, node_6912_nrm_detail)/node_6912_nrm_base.z - node_6912_nrm_detail;
                float3 node_6912 = node_6912_nrm_combined;
                float3 node_208_nrm_base = normalize(lerp(float3(0,0,0.5),node_6912,_Normal_Blending)) + float3(0,0,1);
                float3 node_208_nrm_detail = (i.normalDir+_NormalAngleShift.g) * float3(-1,-1,1);
                float3 node_208_nrm_combined = node_208_nrm_base*dot(node_208_nrm_base, node_208_nrm_detail)/node_208_nrm_base.z - node_208_nrm_detail;
                float3 node_208 = node_208_nrm_combined;
                float3 normalLocal = node_208;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float4 _CutoutTipGrad1TipGrad2_var = tex2D(_CutoutTipGrad1TipGrad2,TRANSFORM_TEX(i.uv0, _CutoutTipGrad1TipGrad2));
                clip(_CutoutTipGrad1TipGrad2_var.r - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Hair_ColorGloss.a;
                float perceptualRoughness = 1.0 - _Hair_ColorGloss.a;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_4546 = (_CutoutTipGrad1TipGrad2_var.g*_Grad1_Power);
                float node_3215 = (_CutoutTipGrad1TipGrad2_var.b*_Grad2_Power);
                float3 node_8051 = ((dot(i.normalDir,lightDirection)*_Grad1_Color.rgb*_Grad1_Power)+lerp(lerp(_Hair_ColorGloss.rgb,(node_4546*_Grad1_Color.rgb),node_4546),(node_3215*_Grad2_Color.rgb),node_3215));
                float3 specularColor = (node_8051*_SpecColorInheritance);
                float specularMonochrome;
                float3 diffuseColor = node_8051; // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _CutoutTipGrad1TipGrad2; uniform float4 _CutoutTipGrad1TipGrad2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _CutoutTipGrad1TipGrad2_var = tex2D(_CutoutTipGrad1TipGrad2,TRANSFORM_TEX(i.uv0, _CutoutTipGrad1TipGrad2));
                clip(_CutoutTipGrad1TipGrad2_var.r - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _CutoutTipGrad1TipGrad2; uniform float4 _CutoutTipGrad1TipGrad2_ST;
            uniform float4 _Hair_ColorGloss;
            uniform float _SpecColorInheritance;
            uniform float4 _Grad1_Color;
            uniform float4 _Grad2_Color;
            uniform float _Grad2_Power;
            uniform float _Grad1_Power;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float4 _CutoutTipGrad1TipGrad2_var = tex2D(_CutoutTipGrad1TipGrad2,TRANSFORM_TEX(i.uv0, _CutoutTipGrad1TipGrad2));
                float node_4546 = (_CutoutTipGrad1TipGrad2_var.g*_Grad1_Power);
                float node_3215 = (_CutoutTipGrad1TipGrad2_var.b*_Grad2_Power);
                float3 node_8051 = ((dot(i.normalDir,lightDirection)*_Grad1_Color.rgb*_Grad1_Power)+lerp(lerp(_Hair_ColorGloss.rgb,(node_4546*_Grad1_Color.rgb),node_4546),(node_3215*_Grad2_Color.rgb),node_3215));
                float3 diffColor = node_8051;
                float3 specColor = (node_8051*_SpecColorInheritance);
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0-specularMonochrome);
                float roughness = 1.0 - _Hair_ColorGloss.a;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    //CustomEditor "ShaderForgeMaterialInspector"
}
