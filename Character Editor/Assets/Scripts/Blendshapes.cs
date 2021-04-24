using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blendshapes : MonoBehaviour
{
    //all blendshapes
    private float Eyes_Narrow_Value = .0f;
    private float Eyes_Wide_Value = .0f;
    private float BodyTypeEctomorph_Value = .0f;
    private float BodyTypeEndomorph_Value = .0f;

    private SkinnedMeshRenderer SMR;


    // Start is called before the first frame update
    void Start()
    {
        SMR = GetComponent<SkinnedMeshRenderer>();
    }


    // Update BLENDSHAPES
    void Update()
    {
        SMR.SetBlendShapeWeight(51, BodyTypeEctomorph_Value);
        SMR.SetBlendShapeWeight(52, BodyTypeEndomorph_Value);
        //Combination Fix
        SMR.SetBlendShapeWeight(53, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) /100);
    }




    //--------------------

    //UPDATE ALL SLIDERS





    public void EctomorphValue(float new_value)
    {
        BodyTypeEctomorph_Value = new_value;
    }
    public void EndomorphValue(float new_value)
    {
        BodyTypeEndomorph_Value = new_value;
    }
  
}
