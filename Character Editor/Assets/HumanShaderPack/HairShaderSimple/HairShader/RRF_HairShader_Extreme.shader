// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:Standard (Specular setup),iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:True,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33909,y:32505,varname:node_2865,prsc:2|diff-8059-OUT,spec-4274-OUT,gloss-2773-OUT,normal-4768-OUT,clip-5027-R,voffset-4045-OUT;n:type:ShaderForge.SFN_Color,id:2666,x:30858,y:33277,ptovrint:False,ptlb:NormalShift,ptin:_NormalShift,varname:node_2350,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.5,c3:0,c4:0;n:type:ShaderForge.SFN_Color,id:953,x:30935,y:32394,ptovrint:False,ptlb:BaseColorGloss,ptin:_BaseColorGloss,varname:node_4133,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3915441,c2:0.4978448,c3:0.75,c4:1;n:type:ShaderForge.SFN_Tex2d,id:4886,x:31421,y:33440,ptovrint:False,ptlb:HairsNormal,ptin:_HairsNormal,varname:node_7035,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_NormalBlend,id:2919,x:31798,y:33291,varname:node_2919,prsc:2|BSE-2666-RGB,DTL-4886-RGB;n:type:ShaderForge.SFN_Multiply,id:4311,x:31937,y:33237,varname:node_4311,prsc:2|A-2919-OUT,B-2919-OUT,C-2919-OUT;n:type:ShaderForge.SFN_Tex2d,id:5027,x:33591,y:32822,ptovrint:False,ptlb:AlphaClip,ptin:_AlphaClip,varname:node_8408,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9a79aa322f67842448907ade5c0439ed,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:4046,x:31258,y:32877,ptovrint:False,ptlb:ShineColor_ToneBost,ptin:_ShineColor_ToneBost,varname:node_1020,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Normalize,id:4768,x:32286,y:33117,varname:node_4768,prsc:2|IN-4311-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7350,x:31502,y:33063,ptovrint:False,ptlb:HairSpecCol_Mixing,ptin:_HairSpecCol_Mixing,varname:node_4098,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.25;n:type:ShaderForge.SFN_Multiply,id:920,x:31937,y:33029,varname:node_920,prsc:2|A-795-OUT,B-8746-OUT;n:type:ShaderForge.SFN_Multiply,id:4274,x:32085,y:32905,varname:node_4274,prsc:2|A-4046-RGB,B-920-OUT;n:type:ShaderForge.SFN_Tex2d,id:7134,x:30969,y:32869,ptovrint:False,ptlb:HairToneVariation,ptin:_HairToneVariation,varname:node_9275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_ValueProperty,id:8625,x:31597,y:33175,ptovrint:False,ptlb:Gloss_Variation,ptin:_Gloss_Variation,varname:node_288,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:7041,x:32085,y:33105,varname:node_7041,prsc:2|A-7134-R,B-8625-OUT;n:type:ShaderForge.SFN_Multiply,id:2773,x:32262,y:32972,varname:node_2773,prsc:2|A-953-A,B-7041-OUT;n:type:ShaderForge.SFN_Multiply,id:278,x:31545,y:32218,varname:node_278,prsc:2|A-3167-OUT,B-953-RGB;n:type:ShaderForge.SFN_Time,id:4565,x:31179,y:33636,varname:node_4565,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:3125,x:31971,y:33534,varname:node_3125,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:2564,x:32187,y:33558,varname:node_2564,prsc:2|IN-3125-V;n:type:ShaderForge.SFN_Cos,id:402,x:32187,y:33703,varname:node_402,prsc:2|IN-6910-OUT;n:type:ShaderForge.SFN_Multiply,id:3710,x:32463,y:33608,varname:node_3710,prsc:2|A-2564-OUT,B-402-OUT,C-2564-OUT;n:type:ShaderForge.SFN_Multiply,id:4045,x:33077,y:33400,varname:node_4045,prsc:2|A-6112-OUT,B-7570-OUT;n:type:ShaderForge.SFN_Multiply,id:896,x:32535,y:33765,varname:node_896,prsc:2|A-3710-OUT,B-5999-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5999,x:32216,y:33874,ptovrint:False,ptlb:MotionAmount,ptin:_MotionAmount,varname:node_5999,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;n:type:ShaderForge.SFN_Vector1,id:8255,x:32520,y:33930,varname:node_8255,prsc:2,v1:0;n:type:ShaderForge.SFN_Append,id:7570,x:32863,y:33778,varname:node_7570,prsc:2|A-896-OUT,B-8255-OUT,C-896-OUT;n:type:ShaderForge.SFN_NormalVector,id:6112,x:32675,y:33419,prsc:2,pt:True;n:type:ShaderForge.SFN_Abs,id:6563,x:32767,y:33253,varname:node_6563,prsc:2|IN-6112-OUT;n:type:ShaderForge.SFN_Divide,id:6910,x:31971,y:33757,varname:node_6910,prsc:2|A-2649-OUT,B-8987-OUT;n:type:ShaderForge.SFN_TexCoord,id:9531,x:30935,y:32223,varname:node_9531,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Color,id:4664,x:33099,y:33717,ptovrint:False,ptlb:NormalShift_copy,ptin:_NormalShift_copy,varname:_NormalShift_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.5,c3:0,c4:0;n:type:ShaderForge.SFN_ViewVector,id:5574,x:32799,y:33893,varname:node_5574,prsc:2;n:type:ShaderForge.SFN_Add,id:3251,x:33271,y:33907,varname:node_3251,prsc:2|A-4664-RGB,B-3895-OUT;n:type:ShaderForge.SFN_OneMinus,id:3895,x:33045,y:33893,varname:node_3895,prsc:2|IN-5574-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:8746,x:31716,y:33019,varname:node_8746,prsc:2,min:0,max:10|IN-7350-OUT;n:type:ShaderForge.SFN_Multiply,id:2356,x:31491,y:32897,varname:node_2356,prsc:2|A-4046-RGB,B-4046-A;n:type:ShaderForge.SFN_Multiply,id:795,x:31716,y:32837,varname:node_795,prsc:2|A-7134-RGB,B-2356-OUT;n:type:ShaderForge.SFN_Multiply,id:2649,x:31595,y:33692,varname:node_2649,prsc:2|A-4565-TSL,B-6460-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:2198,x:31172,y:33735,varname:node_2198,prsc:2;n:type:ShaderForge.SFN_Add,id:6460,x:31422,y:33703,varname:node_6460,prsc:2|A-4565-T,B-2198-X,C-2198-Z;n:type:ShaderForge.SFN_Slider,id:8987,x:31357,y:33967,ptovrint:False,ptlb:Fast-Slow,ptin:_FastSlow,varname:node_8987,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:150,max:300;n:type:ShaderForge.SFN_Color,id:1728,x:30910,y:32677,ptovrint:False,ptlb:Tip_Color,ptin:_Tip_Color,varname:node_1728,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1172414,c2:1,c3:0,c4:0.5;n:type:ShaderForge.SFN_OneMinus,id:6760,x:31437,y:32372,varname:node_6760,prsc:2|IN-3167-OUT;n:type:ShaderForge.SFN_Multiply,id:100,x:31752,y:32384,varname:node_100,prsc:2|A-6760-OUT,B-1728-RGB;n:type:ShaderForge.SFN_Blend,id:8059,x:32169,y:32318,varname:node_8059,prsc:2,blmd:5,clmp:True|SRC-278-OUT,DST-100-OUT;n:type:ShaderForge.SFN_Multiply,id:3167,x:31185,y:32351,varname:node_3167,prsc:2|A-9531-V,B-6829-OUT;n:type:ShaderForge.SFN_ValueProperty,id:745,x:30852,y:32583,ptovrint:False,ptlb:TipAmount,ptin:_TipAmount,varname:node_745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ConstantClamp,id:6829,x:31039,y:32526,varname:node_6829,prsc:2,min:0,max:5|IN-745-OUT;proporder:953-4046-4886-5027-2666-7350-7134-8625-5999-8987-1728-745;pass:END;sub:END;*/

Shader "RRF_HumanShaders/HairShader1/RRF_HairShader_Extreme" {
    Properties {
        _BaseColorGloss ("BaseColorGloss", Color) = (0.3915441,0.4978448,0.75,1)
        _ShineColor_ToneBost ("ShineColor_ToneBost", Color) = (0.5,0.5,0.5,1)
        _HairsNormal ("HairsNormal", 2D) = "bump" {}
        _AlphaClip ("AlphaClip", 2D) = "white" {}
        _NormalShift ("NormalShift", Color) = (0,0.5,0,0)
        _HairSpecCol_Mixing ("HairSpecCol_Mixing", Float ) = 1.25
        _HairToneVariation ("HairToneVariation", 2D) = "white" {}
        _Gloss_Variation ("Gloss_Variation", Float ) = 0.5
        _MotionAmount ("MotionAmount", Float ) = 0.01
        _FastSlow ("Fast-Slow", Range(1, 300)) = 150
        _Tip_Color ("Tip_Color", Color) = (0.1172414,1,0,0.5)
        _TipAmount ("TipAmount", Float ) = 1
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
            uniform float4 _NormalShift;
            uniform float4 _BaseColorGloss;
            uniform sampler2D _HairsNormal; uniform float4 _HairsNormal_ST;
            uniform sampler2D _AlphaClip; uniform float4 _AlphaClip_ST;
            uniform float4 _ShineColor_ToneBost;
            uniform float _HairSpecCol_Mixing;
            uniform sampler2D _HairToneVariation; uniform float4 _HairToneVariation_ST;
            uniform float _Gloss_Variation;
            uniform float _MotionAmount;
            uniform float _FastSlow;
            uniform float4 _Tip_Color;
            uniform float _TipAmount;
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
                float node_2564 = (1.0 - o.uv0.g);
                float4 node_4565 = _Time;
                float node_896 = ((node_2564*cos(((node_4565.r*(node_4565.g+mul(unity_ObjectToWorld, v.vertex).r+mul(unity_ObjectToWorld, v.vertex).b))/_FastSlow))*node_2564)*_MotionAmount);
                v.vertex.xyz += (v.normal*float3(node_896,0.0,node_896));
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
                float3 _HairsNormal_var = UnpackNormal(tex2D(_HairsNormal,TRANSFORM_TEX(i.uv0, _HairsNormal)));
                float3 node_2919_nrm_base = _NormalShift.rgb + float3(0,0,1);
                float3 node_2919_nrm_detail = _HairsNormal_var.rgb * float3(-1,-1,1);
                float3 node_2919_nrm_combined = node_2919_nrm_base*dot(node_2919_nrm_base, node_2919_nrm_detail)/node_2919_nrm_base.z - node_2919_nrm_detail;
                float3 node_2919 = node_2919_nrm_combined;
                float3 normalLocal = normalize((node_2919*node_2919*node_2919));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 _AlphaClip_var = tex2D(_AlphaClip,TRANSFORM_TEX(i.uv0, _AlphaClip));
                clip(_AlphaClip_var.r - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _HairToneVariation_var = tex2D(_HairToneVariation,TRANSFORM_TEX(i.uv0, _HairToneVariation));
                float gloss = (_BaseColorGloss.a*(_HairToneVariation_var.r*_Gloss_Variation));
                float perceptualRoughness = 1.0 - (_BaseColorGloss.a*(_HairToneVariation_var.r*_Gloss_Variation));
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
                float3 specularColor = (_ShineColor_ToneBost.rgb*((_HairToneVariation_var.rgb*(_ShineColor_ToneBost.rgb*_ShineColor_ToneBost.a))*clamp(_HairSpecCol_Mixing,0,10)));
                float specularMonochrome;
                float node_3167 = (i.uv0.g*clamp(_TipAmount,0,5));
                float3 diffuseColor = saturate(max((node_3167*_BaseColorGloss.rgb),((1.0 - node_3167)*_Tip_Color.rgb))); // Need this for specular when using metallic
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
            uniform float4 _NormalShift;
            uniform float4 _BaseColorGloss;
            uniform sampler2D _HairsNormal; uniform float4 _HairsNormal_ST;
            uniform sampler2D _AlphaClip; uniform float4 _AlphaClip_ST;
            uniform float4 _ShineColor_ToneBost;
            uniform float _HairSpecCol_Mixing;
            uniform sampler2D _HairToneVariation; uniform float4 _HairToneVariation_ST;
            uniform float _Gloss_Variation;
            uniform float _MotionAmount;
            uniform float _FastSlow;
            uniform float4 _Tip_Color;
            uniform float _TipAmount;
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
                float node_2564 = (1.0 - o.uv0.g);
                float4 node_4565 = _Time;
                float node_896 = ((node_2564*cos(((node_4565.r*(node_4565.g+mul(unity_ObjectToWorld, v.vertex).r+mul(unity_ObjectToWorld, v.vertex).b))/_FastSlow))*node_2564)*_MotionAmount);
                v.vertex.xyz += (v.normal*float3(node_896,0.0,node_896));
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
                float3 _HairsNormal_var = UnpackNormal(tex2D(_HairsNormal,TRANSFORM_TEX(i.uv0, _HairsNormal)));
                float3 node_2919_nrm_base = _NormalShift.rgb + float3(0,0,1);
                float3 node_2919_nrm_detail = _HairsNormal_var.rgb * float3(-1,-1,1);
                float3 node_2919_nrm_combined = node_2919_nrm_base*dot(node_2919_nrm_base, node_2919_nrm_detail)/node_2919_nrm_base.z - node_2919_nrm_detail;
                float3 node_2919 = node_2919_nrm_combined;
                float3 normalLocal = normalize((node_2919*node_2919*node_2919));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float4 _AlphaClip_var = tex2D(_AlphaClip,TRANSFORM_TEX(i.uv0, _AlphaClip));
                clip(_AlphaClip_var.r - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _HairToneVariation_var = tex2D(_HairToneVariation,TRANSFORM_TEX(i.uv0, _HairToneVariation));
                float gloss = (_BaseColorGloss.a*(_HairToneVariation_var.r*_Gloss_Variation));
                float perceptualRoughness = 1.0 - (_BaseColorGloss.a*(_HairToneVariation_var.r*_Gloss_Variation));
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (_ShineColor_ToneBost.rgb*((_HairToneVariation_var.rgb*(_ShineColor_ToneBost.rgb*_ShineColor_ToneBost.a))*clamp(_HairSpecCol_Mixing,0,10)));
                float specularMonochrome;
                float node_3167 = (i.uv0.g*clamp(_TipAmount,0,5));
                float3 diffuseColor = saturate(max((node_3167*_BaseColorGloss.rgb),((1.0 - node_3167)*_Tip_Color.rgb))); // Need this for specular when using metallic
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
            uniform sampler2D _AlphaClip; uniform float4 _AlphaClip_ST;
            uniform float _MotionAmount;
            uniform float _FastSlow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
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
                float3 normalDir : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float node_2564 = (1.0 - o.uv0.g);
                float4 node_4565 = _Time;
                float node_896 = ((node_2564*cos(((node_4565.r*(node_4565.g+mul(unity_ObjectToWorld, v.vertex).r+mul(unity_ObjectToWorld, v.vertex).b))/_FastSlow))*node_2564)*_MotionAmount);
                v.vertex.xyz += (v.normal*float3(node_896,0.0,node_896));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 _AlphaClip_var = tex2D(_AlphaClip,TRANSFORM_TEX(i.uv0, _AlphaClip));
                clip(_AlphaClip_var.r - 0.5);
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
            uniform float4 _BaseColorGloss;
            uniform float4 _ShineColor_ToneBost;
            uniform float _HairSpecCol_Mixing;
            uniform sampler2D _HairToneVariation; uniform float4 _HairToneVariation_ST;
            uniform float _Gloss_Variation;
            uniform float _MotionAmount;
            uniform float _FastSlow;
            uniform float4 _Tip_Color;
            uniform float _TipAmount;
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
                float node_2564 = (1.0 - o.uv0.g);
                float4 node_4565 = _Time;
                float node_896 = ((node_2564*cos(((node_4565.r*(node_4565.g+mul(unity_ObjectToWorld, v.vertex).r+mul(unity_ObjectToWorld, v.vertex).b))/_FastSlow))*node_2564)*_MotionAmount);
                v.vertex.xyz += (v.normal*float3(node_896,0.0,node_896));
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
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float node_3167 = (i.uv0.g*clamp(_TipAmount,0,5));
                float3 diffColor = saturate(max((node_3167*_BaseColorGloss.rgb),((1.0 - node_3167)*_Tip_Color.rgb)));
                float4 _HairToneVariation_var = tex2D(_HairToneVariation,TRANSFORM_TEX(i.uv0, _HairToneVariation));
                float3 specColor = (_ShineColor_ToneBost.rgb*((_HairToneVariation_var.rgb*(_ShineColor_ToneBost.rgb*_ShineColor_ToneBost.a))*clamp(_HairSpecCol_Mixing,0,10)));
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0-specularMonochrome);
                float roughness = 1.0 - (_BaseColorGloss.a*(_HairToneVariation_var.r*_Gloss_Variation));
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Standard (Specular setup)"
    //CustomEditor "ShaderForgeMaterialInspector"
}
