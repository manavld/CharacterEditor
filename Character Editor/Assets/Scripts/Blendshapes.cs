using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blendshapes : MonoBehaviour
{
    //all blendshapes
    private float BodyTypeEctomorph_Slider = .0f;
    private float BodyTypeEndomorph_Slider = .0f;
    private float NoseNostrilsWidth_Slider = .0f;

    private SkinnedMeshRenderer SMR;


    // Start is called before the first frame update
    void Start()
    {
        SMR = GetComponent<SkinnedMeshRenderer>();
    }


    // Update BLENDSHAPES
    void Update()
    {
        SMR.SetBlendShapeWeight(51, BodyTypeEctomorph_Slider);
        SMR.SetBlendShapeWeight(52, BodyTypeEndomorph_Slider);
        //Combination Fix
        SMR.SetBlendShapeWeight(53, (BodyTypeEctomorph_Slider * BodyTypeEndomorph_Slider)/100);
    }




    //--------------------

    //UPDATE ALL SLIDERS
    public void EctomorphValue(float new_value)
    {
        BodyTypeEctomorph_Slider = new_value;
    }
    public void EndomorphhValue(float new_value)
    {
        BodyTypeEndomorph_Slider = new_value;
    }
    public void NoseWidthValue(float new_value)
    {
        NoseNostrilsWidth_Slider = new_value;
    }
}
