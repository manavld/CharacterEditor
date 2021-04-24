using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blendshapes : MonoBehaviour
{
    //Initializing all blendshapes

    //head shape -> 6 sliders
    private float Head_Oval_Value_0 = .0f;
    private float Head_Round_Value_1 = .0f;
    private float Head_Square_Value_2 = .0f;
            //Head_Round + Head_Oval Fix -> 9
    private float Forehead_Big_3 = .0f;
    private float Forehead_Small_4 = .0f;
    private float Forehead_Wide_5 = .0f;
    private float Forehead_Narrow_6 = .0f;
    private float Cheekbones_Low_7 = .0f;
    private float Cheekbones_High_8 = .0f;

    //nose -> 8 or 10 sliders (straight/round front/profile)
    private float NoseBase_Narrow_Value_10 = .0f;
    private float NoseBase_Wide_Value_11 = .0f;
    private float NoseBase_Long_Value_12 = .0f;
    private float NoseBase_Short_Value_13 = .0f;
    private float NoseNostrils_Wide_Value_14 = .0f;
    private float NoseNostrils_Narrow_Value_15 = .0f;
    private float NosePoint_StraightFront_Value_16 = .0f;
    private float NosePoint_RoundFront_Value_17 = .0f;
    private float NosePoint_StraightProfile_Value_18 = .0f;
    private float NosePoint_RoundProfile_Value_19 = .0f;
    private float NosePoint_Wide_Value_20 = .0f;
    private float NoseBase_Bump_Value_21 = .0f;
    private float NosePoint_High_Value_22 = .0f;
    private float NosePoint_Low_Value_23 = .0f;

    //ear -> 3 sliders
    private float Ear_Big_Value_24 = .0f;
    private float Ear_Small_Value_25 = .0f;
    private float EarLobes_Detached_Value_26 = .0f;
    private float EarLobes_Attached_Value_27 = .0f;
    private float Ear_CloseToHead_Value_28 = .0f;
    private float Ear_FarFromHead_Value_29 = .0f;

    //chin -> 5 sliders
    private float ChinProfile_Strong_Value_30 = .0f;
    private float ChinProfile_Slight_Value_31 = .0f;
    private float ChinFront_Low_Value_32 = .0f;
    private float ChinFront_High_Value_33 = .0f;
    private float ChinShape_Square_Value_34 = .0f;
    private float ChinShape_Round_Value_35 = .0f;
    private float ChinShape_Pointy_Value_36 = .0f;

    //lips -> 3 sliders
    private float Lips_Narrow_Value_37 = .0f;
    private float Lips_Wide_Value_38 = .0f;
    private float LipsUpper_Thin_Value_39 = .0f;
    private float LipsUpper_Thick_Value_40 = .0f;
    private float LipsLower_Thin_Value_41 = .0f;
    private float LipsLower_Thick_Value_42 = .0f;
            //LipsUpper_Thin`+ Lips_Narrow Fix -> 43
            //LipsUpper_Thick + NoseBase_Long Fix -> 44

    //Eyes -> 4 sliders
    private float Eyes_Narrow_Value_45 = .0f;
    private float Eyes_Wide_Value_46 = .0f;
    private float EyesSize_Small_Value_47 = .0f;
    private float EyesSize_Big_Value_48 = .0f;
    private float EyesShape_Round_Value_49 = .0f;
    private float EyesShape_Almond_Value_50 = .0f;
    
    //body types -> 2 sliders
    private float BodyTypeEctomorph_Value_51 = .0f;
    private float BodyTypeEndomorph_Value_52 = .0f;
            //BodyTypes Fiz -> 53

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
        SMR.SetBlendShapeWeight(9, (Head_Oval_Value_0 * Head_Round_Value_1) / 100);

        SMR.SetBlendShapeWeight(10, NoseBase_Narrow_Value_10);
        SMR.SetBlendShapeWeight(11, NoseBase_Wide_Value_11);
        SMR.SetBlendShapeWeight(12, NoseBase_Long_Value_12);
        SMR.SetBlendShapeWeight(13, NoseBase_Short_Value_13);
        SMR.SetBlendShapeWeight(14, NoseNostrils_Wide_Value_14);
        SMR.SetBlendShapeWeight(15, NoseNostrils_Narrow_Value_15);
        SMR.SetBlendShapeWeight(16, NosePoint_StraightFront_Value_16);
        SMR.SetBlendShapeWeight(17, NosePoint_RoundFront_Value_17);
        SMR.SetBlendShapeWeight(18, NosePoint_StraightProfile_Value_18);
        SMR.SetBlendShapeWeight(19, NosePoint_RoundProfile_Value_19);
        SMR.SetBlendShapeWeight(20, NosePoint_Wide_Value_20);
        SMR.SetBlendShapeWeight(21, NoseBase_Bump_Value_21);
        SMR.SetBlendShapeWeight(22, NosePoint_High_Value_22);
        SMR.SetBlendShapeWeight(23, NosePoint_Low_Value_23);

        SMR.SetBlendShapeWeight(24, Ear_Big_Value_24);
        SMR.SetBlendShapeWeight(25, Ear_Small_Value_25);
        SMR.SetBlendShapeWeight(26, EarLobes_Detached_Value_26);
        SMR.SetBlendShapeWeight(27, EarLobes_Attached_Value_27);
        SMR.SetBlendShapeWeight(28, Ear_CloseToHead_Value_28);
        SMR.SetBlendShapeWeight(29, Ear_FarFromHead_Value_29);

        SMR.SetBlendShapeWeight(30, ChinProfile_Strong_Value_30);
        SMR.SetBlendShapeWeight(31, ChinProfile_Slight_Value_31);
        SMR.SetBlendShapeWeight(32, ChinFront_Low_Value_32);
        SMR.SetBlendShapeWeight(33, ChinFront_High_Value_33);
        SMR.SetBlendShapeWeight(34, ChinShape_Square_Value_34);
        SMR.SetBlendShapeWeight(35, ChinShape_Round_Value_35);
        SMR.SetBlendShapeWeight(36, ChinShape_Pointy_Value_36);

        SMR.SetBlendShapeWeight(37, Lips_Narrow_Value_37);
        SMR.SetBlendShapeWeight(38, Lips_Wide_Value_38);
        SMR.SetBlendShapeWeight(39, LipsUpper_Thin_Value_39);
        SMR.SetBlendShapeWeight(40, LipsUpper_Thick_Value_40);
        SMR.SetBlendShapeWeight(41, LipsLower_Thin_Value_41);
        SMR.SetBlendShapeWeight(42, LipsLower_Thick_Value_42);
        SMR.SetBlendShapeWeight(43, (LipsUpper_Thin_Value_39 * Lips_Narrow_Value_37) / 100);
        SMR.SetBlendShapeWeight(44, (LipsUpper_Thick_Value_40 * NoseBase_Long_Value_12) / 100);

        SMR.SetBlendShapeWeight(45, Eyes_Narrow_Value_45);
        SMR.SetBlendShapeWeight(46, Eyes_Wide_Value_46);
        SMR.SetBlendShapeWeight(47, EyesSize_Small_Value_47);
        SMR.SetBlendShapeWeight(48, EyesSize_Big_Value_48);
        SMR.SetBlendShapeWeight(49, EyesShape_Round_Value_49);
        SMR.SetBlendShapeWeight(50, EyesShape_Almond_Value_50);

        SMR.SetBlendShapeWeight(51, BodyTypeEctomorph_Value_51);
        SMR.SetBlendShapeWeight(52, BodyTypeEndomorph_Value_52);
        //Combination Fix
        SMR.SetBlendShapeWeight(53, (BodyTypeEctomorph_Value_51 * BodyTypeEndomorph_Value_52) /100);
    }




    //--------------------

    //UPDATE ALL SLIDERS
    public void EyesWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Eyes_Wide_Value_46 = new_value;
            Eyes_Narrow_Value_45 = 0;
        }
        else if (new_value <= 0)
        {
            Eyes_Narrow_Value_45 = -new_value;
            Eyes_Wide_Value_46 = 0;
        }
    }

    public void EctomorphValue(float new_value)
    {
        BodyTypeEctomorph_Value_51 = new_value;
    }
    public void EndomorphValue(float new_value)
    {
        BodyTypeEndomorph_Value_52 = new_value;
    }
  
}
