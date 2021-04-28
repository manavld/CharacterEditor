using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Blendshapes : MonoBehaviour
{
    //Initializing all blendshapes

    //head shape -> 6 sliders
    private float Head_Oval_Value_0 = .0f;
    private float Head_Round_Value_1 = .0f;
    private float Head_Square_Value_2 = .0f;
    private float Forehead_Big_3 = .0f;
    private float Forehead_Small_4 = .0f;
    private float Forehead_Wide_5 = .0f;
    private float Forehead_Narrow_6 = .0f;
    private float Cheekbones_Low_7 = .0f;
    private float Cheekbones_High_8 = .0f;

    //nose -> 8 or 10 sliders (straight/round front/profile)
    private float NoseBase_Narrow_Value_9 = .0f;
    private float NoseBase_Wide_Value_10 = .0f;
    private float NoseBase_Long_Value_11 = .0f;
    private float NoseBase_Short_Value_12 = .0f;
    private float NoseNostrils_Wide_Value_13 = .0f;
    private float NoseNostrils_Narrow_Value_14 = .0f;
    private float NosePoint_StraightFront_Value_15 = .0f;
    private float NosePoint_RoundFront_Value_17 = .0f;
    private float NosePoint_StraightProfile_Value_16 = .0f;
    private float NosePoint_RoundProfile_Value_18 = .0f;
    private float NosePoint_Wide_Value_19 = .0f;
    private float NoseBase_Bump_Value_20 = .0f;
    private float NosePoint_High_Value_21 = .0f;
    private float NosePoint_Low_Value_22 = .0f;

    //ear -> 3 sliders
    private float Ear_Big_Value_23 = .0f;
    private float Ear_Small_Value_24 = .0f;
    private float EarLobes_Detached_Value_25 = .0f;
    private float EarLobes_Attached_Value_26 = .0f;
    private float Ear_CloseToHead_Value_27 = .0f;
    private float Ear_FarFromHead_Value_28 = .0f;

    //chin -> 5 sliders
    private float ChinProfile_Strong_Value_29 = .0f;
    private float ChinProfile_Slight_Value_30 = .0f;
    private float ChinFront_Low_Value_31 = .0f;
    private float ChinFront_High_Value_32 = .0f;
    private float ChinShape_Square_Value_33 = .0f;
    private float ChinShape_Round_Value_34 = .0f;
    private float ChinShape_Pointy_Value_35 = .0f;

    //lips -> 3 sliders
    private float Lips_Narrow_Value_36 = .0f;
    private float Lips_Wide_Value_37 = .0f;
    private float LipsUpper_Thin_Value_38 = .0f;
    private float LipsUpper_Thick_Value_39 = .0f;
    private float LipsLower_Thin_Value_40 = .0f;
    private float LipsLower_Thick_Value_41 = .0f;
    //LipsUpper_Thick + NoseBase_Long Fix -> 42
    //Chin Round + Chin Square Fix -> 43

    //Eyes -> 4 sliders
    private float Eyes_Narrow_Value_44 = .0f;
    private float Eyes_Wide_Value_45 = .0f;
    private float EyesSize_Small_Value_46 = .0f;
    private float EyesSize_Big_Value_47 = .0f;
    private float EyesShape_Round_Value_48 = .0f;
    private float EyesShape_Almond_Value_49 = .0f;

    //body types -> 2 sliders
    private float BodyTypeEctomorph_Value_50 = .0f;
    private float BodyTypeEndomorph_Value_51 = .0f;
    private float BodyTypeMesomorph_Value_52 = .0f;
    //Endomorph + Mesomorph Fix -> 53

    private SkinnedMeshRenderer SMR;


    // Start is called before the first frame update
    void Start()
    {
        SMR = GetComponent<SkinnedMeshRenderer>();
    }

    // Update BLENDSHAPES
    void Update()
    {
        SMR.SetBlendShapeWeight(0, Head_Oval_Value_0);
        SMR.SetBlendShapeWeight(1, Head_Round_Value_1);
        SMR.SetBlendShapeWeight(2, Head_Square_Value_2);
        SMR.SetBlendShapeWeight(3, Forehead_Big_3);
        SMR.SetBlendShapeWeight(4, Forehead_Small_4);
        SMR.SetBlendShapeWeight(5, Forehead_Wide_5);
        SMR.SetBlendShapeWeight(6, Forehead_Narrow_6);
        SMR.SetBlendShapeWeight(7, Cheekbones_Low_7);
        SMR.SetBlendShapeWeight(8, Cheekbones_High_8);

        SMR.SetBlendShapeWeight(9, NoseBase_Narrow_Value_9);
        SMR.SetBlendShapeWeight(10, NoseBase_Wide_Value_10);
        SMR.SetBlendShapeWeight(11, NoseBase_Long_Value_11);
        SMR.SetBlendShapeWeight(12, NoseBase_Short_Value_12);
        SMR.SetBlendShapeWeight(13, NoseNostrils_Wide_Value_13);
        SMR.SetBlendShapeWeight(14, NoseNostrils_Narrow_Value_14);
        SMR.SetBlendShapeWeight(15, NosePoint_StraightFront_Value_15);
        SMR.SetBlendShapeWeight(16, NosePoint_StraightProfile_Value_16);
        SMR.SetBlendShapeWeight(17, NosePoint_RoundFront_Value_17);
        SMR.SetBlendShapeWeight(18, NosePoint_RoundProfile_Value_18);
        SMR.SetBlendShapeWeight(19, NosePoint_Wide_Value_19);
        SMR.SetBlendShapeWeight(20, NoseBase_Bump_Value_20);
        SMR.SetBlendShapeWeight(21, NosePoint_High_Value_21);
        SMR.SetBlendShapeWeight(22, NosePoint_Low_Value_22);

        SMR.SetBlendShapeWeight(23, Ear_Big_Value_23);
        SMR.SetBlendShapeWeight(24, Ear_Small_Value_24);
        SMR.SetBlendShapeWeight(25, EarLobes_Detached_Value_25);
        SMR.SetBlendShapeWeight(26, EarLobes_Attached_Value_26);
        SMR.SetBlendShapeWeight(27, Ear_CloseToHead_Value_27);
        SMR.SetBlendShapeWeight(28, Ear_FarFromHead_Value_28);

        SMR.SetBlendShapeWeight(29, ChinProfile_Strong_Value_29);
        SMR.SetBlendShapeWeight(30, ChinProfile_Slight_Value_30);
        SMR.SetBlendShapeWeight(31, ChinFront_Low_Value_31);
        SMR.SetBlendShapeWeight(32, ChinFront_High_Value_32);
        SMR.SetBlendShapeWeight(33, ChinShape_Square_Value_33);
        SMR.SetBlendShapeWeight(34, ChinShape_Round_Value_34);
        SMR.SetBlendShapeWeight(35, ChinShape_Pointy_Value_35);

        SMR.SetBlendShapeWeight(36, Lips_Narrow_Value_36);
        SMR.SetBlendShapeWeight(37, Lips_Wide_Value_37);
        SMR.SetBlendShapeWeight(38, LipsUpper_Thin_Value_38);
        SMR.SetBlendShapeWeight(39, LipsUpper_Thick_Value_39);
        SMR.SetBlendShapeWeight(40, LipsLower_Thin_Value_40);
        SMR.SetBlendShapeWeight(41, LipsLower_Thick_Value_41);
        SMR.SetBlendShapeWeight(42, (LipsUpper_Thick_Value_39 * NoseBase_Long_Value_11) / 100);
        SMR.SetBlendShapeWeight(43, (ChinShape_Round_Value_34 * ChinShape_Square_Value_33) / 100);

        SMR.SetBlendShapeWeight(44, Eyes_Narrow_Value_44);
        SMR.SetBlendShapeWeight(45, Eyes_Wide_Value_45);
        SMR.SetBlendShapeWeight(46, EyesSize_Small_Value_46);
        SMR.SetBlendShapeWeight(47, EyesSize_Big_Value_47);
        SMR.SetBlendShapeWeight(48, EyesShape_Round_Value_48);
        SMR.SetBlendShapeWeight(49, EyesShape_Almond_Value_49);

        SMR.SetBlendShapeWeight(50, BodyTypeEctomorph_Value_50);
        SMR.SetBlendShapeWeight(51, BodyTypeEndomorph_Value_51);
        SMR.SetBlendShapeWeight(52, BodyTypeMesomorph_Value_52);
        //Combination Fix
        SMR.SetBlendShapeWeight(53, (BodyTypeMesomorph_Value_52 * BodyTypeEndomorph_Value_51) / 100);
    }

    //--------------------

    //UPDATE ALL SLIDERS

    //Head
    public void HeadOvalSlider(float new_value)
    {
        Head_Oval_Value_0 = new_value;
    }
    public void HeadRoundSlider(float new_value)
    {
        Head_Round_Value_1 = new_value;
    }
    public void HeadSquareSlider(float new_value)
    {
        Head_Square_Value_2 = new_value;
    }
    public void ForeheadSizeSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Forehead_Big_3 = new_value;
            Forehead_Small_4 = 0;
        }
        else if (new_value <= 0)
        {
            Forehead_Small_4 = -new_value;
            Forehead_Big_3 = 0;
        }
    }
    public void ForeheadWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Forehead_Wide_5 = new_value;
            Forehead_Narrow_6 = 0;
        }
        else if (new_value <= 0)
        {
            Forehead_Narrow_6 = -new_value;
            Forehead_Wide_5 = 0;
        }
    }
    public void CheekbonesPositionSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Cheekbones_High_8 = new_value;
            Cheekbones_Low_7 = 0;
        }
        else if (new_value <= 0)
        {
            Cheekbones_Low_7 = -new_value;
            Cheekbones_High_8 = 0;
        }
    }


    //Nose
    public void NoseBaseWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            NoseBase_Wide_Value_10 = new_value;
            NoseBase_Narrow_Value_9 = 0;
        }
        else if (new_value <= 0)
        {
            NoseBase_Narrow_Value_9 = -new_value;
            NoseBase_Wide_Value_10 = 0;
        }
    }
    public void NoseBaseLengthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            NoseBase_Long_Value_11 = new_value;
            NoseBase_Short_Value_12 = 0;
        }
        else if (new_value <= 0)
        {
            NoseBase_Short_Value_12 = -new_value;
            NoseBase_Long_Value_11 = 0;
        }
    }
    public void NostrilsWidth(float new_value)
    {
        if (new_value >= 0)
        {
            NoseNostrils_Wide_Value_13 = new_value;
            NoseNostrils_Narrow_Value_14 = 0;
        }
        else if (new_value <= 0)
        {
            NoseNostrils_Narrow_Value_14 = -new_value;
            NoseNostrils_Wide_Value_13 = 0;
        }
    }
    public void NosePointStraightFrontSlider(float new_value)
    {
        NosePoint_StraightFront_Value_15 = new_value;
    }
    public void NosePointRoundFrontSlider(float new_value)
    {
        NosePoint_RoundFront_Value_17 = new_value;
    }
    public void NosePointStraightProfileSlider(float new_value)
    {
        NosePoint_StraightProfile_Value_16 = new_value;
    }
    public void NosePointRoundProfileSlider(float new_value)
    {
        NosePoint_RoundProfile_Value_18 = new_value;
    }
    public void NosePointWidthSlider(float new_value)
    {
        NosePoint_Wide_Value_19 = new_value;
    }
    public void NoseBumpSlider(float new_value)
    {
        NoseBase_Bump_Value_20 = new_value;
    }
    public void NosePointPositionSlider(float new_value)
    {
        if (new_value >= 0)
        {
            NosePoint_High_Value_21 = new_value;
            NosePoint_Low_Value_22 = 0;
        }
        else if (new_value <= 0)
        {
            NosePoint_Low_Value_22 = -new_value;
            NosePoint_High_Value_21 = 0;
        }
    }

    //Ear
    public void EarSizeSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Ear_Big_Value_23 = new_value;
            Ear_Small_Value_24 = 0;
        }
        else if (new_value <= 0)
        {
            Ear_Small_Value_24 = -new_value;
            Ear_Big_Value_23 = 0;
        }
    }
    public void EarLobesSlider(float new_value)
    {
        if (new_value >= 0)
        {
            EarLobes_Attached_Value_26 = new_value;
            EarLobes_Detached_Value_25 = 0;
        }
        else if (new_value <= 0)
        {
            EarLobes_Detached_Value_25 = -new_value;
            EarLobes_Attached_Value_26 = 0;
        }
    }
    public void EarDistanceSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Ear_FarFromHead_Value_28 = new_value;
            Ear_CloseToHead_Value_27 = 0;
        }
        else if (new_value <= 0)
        {
            Ear_CloseToHead_Value_27 = -new_value;
            Ear_FarFromHead_Value_28 = 0;
        }
    }

    //Chin
    public void ChinProminenceSlider(float new_value)
    {
        if (new_value >= 0)
        {
            ChinProfile_Strong_Value_29 = new_value;
            ChinProfile_Slight_Value_30 = 0;
        }
        else if (new_value <= 0)
        {
            ChinProfile_Slight_Value_30 = -new_value;
            ChinProfile_Strong_Value_29 = 0;
        }
    }
    public void ChinPositionSlider(float new_value)
    {
        if (new_value >= 0)
        {
            ChinFront_High_Value_32 = new_value;
            ChinFront_Low_Value_31 = 0;
        }
        else if (new_value <= 0)
        {
            ChinFront_Low_Value_31 = -new_value;
            ChinFront_High_Value_32 = 0;
        }
    }
    public void ChinShapeSquareSlider(float new_value)
    {
        ChinShape_Square_Value_33 = new_value;
    }
    public void ChinShapeRoundSlider(float new_value)
    {
        ChinShape_Round_Value_34 = new_value;
    }
    public void ChinShapePointySlider(float new_value)
    {
        ChinShape_Pointy_Value_35 = new_value;
    }

    //Mouth
    public void MouthWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Lips_Wide_Value_37 = new_value;
            Lips_Narrow_Value_36 = 0;
        }
        else if (new_value <= 0)
        {
            Lips_Narrow_Value_36 = -new_value;
            Lips_Wide_Value_37 = 0;
        }
    }
    public void UpperLipSlider(float new_value)
    {
        if (new_value >= 0)
        {
            LipsUpper_Thick_Value_39 = new_value;
            LipsUpper_Thin_Value_38 = 0;
        }
        else if (new_value <= 0)
        {
            LipsUpper_Thin_Value_38 = -new_value;
            LipsUpper_Thick_Value_39 = 0;
        }
    }
    public void LowerLipsSlider(float new_value)
    {
        if (new_value >= 0)
        {
            LipsLower_Thick_Value_41 = new_value;
            LipsLower_Thin_Value_40 = 0;
        }
        else if (new_value <= 0)
        {
            LipsLower_Thin_Value_40 = -new_value;
            LipsLower_Thick_Value_41 = 0;
        }
    }



    //Eyes
    public void EyesWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Eyes_Wide_Value_45 = new_value;
            Eyes_Narrow_Value_44 = 0;
        }
        else if (new_value <= 0)
        {
            Eyes_Narrow_Value_44 = -new_value;
            Eyes_Wide_Value_45 = 0;
        }
    }
    public void EyesSizeSlider(float new_value)
    {
        if (new_value >= 0)
        {
            EyesSize_Big_Value_47 = new_value;
            EyesSize_Small_Value_46 = 0;
        }
        else if (new_value <= 0)
        {
            EyesSize_Small_Value_46 = -new_value;
            EyesSize_Big_Value_47 = 0;
        }
    }
    public void EyesShapeRoundSlider(float new_value)
    {
        EyesShape_Round_Value_48 = new_value;
    }
    public void EyesShapeAlmondSlider(float new_value)
    {
        EyesShape_Almond_Value_49 = new_value;
    }

    //Body Types
    public void EctomorphValue(float new_value)
    {
        if (new_value >= 0)
        {
            BodyTypeMesomorph_Value_52 = new_value;
            BodyTypeEctomorph_Value_50 = 0;
        }
        else if (new_value <= 0)
        {
            BodyTypeEctomorph_Value_50 = -new_value;
            BodyTypeMesomorph_Value_52 = 0;
        }
    }
    public void EndomorphValue(float new_value)
    {
        BodyTypeEndomorph_Value_51 = new_value;
    }
}
