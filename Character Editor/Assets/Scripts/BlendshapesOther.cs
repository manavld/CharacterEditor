using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendshapesOther : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        SMR.SetBlendShapeWeight(0, Eyes_Narrow_Value);
        SMR.SetBlendShapeWeight(1, Eyes_Wide_Value);
        SMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        SMR.SetBlendShapeWeight(3, BodyTypeEndomorph_Value);
        //Combination Fix
        SMR.SetBlendShapeWeight(4, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
      
    }




    //---------------------------

    //UPDATE ALL SLIDERS
    public void EyesWidthSlider(float new_value)
    {
        if (new_value >= 0)
        {
            Eyes_Wide_Value = new_value;
            Eyes_Narrow_Value = 0;
        }
        else if(new_value <= 0)
        {
            Eyes_Narrow_Value = -new_value;
            Eyes_Wide_Value = 0;
        }
    }
    
    public void EctomorphSlider(float new_value)
    {
        BodyTypeEctomorph_Value = new_value;
    }
    public void EndomorphSlider(float new_value)
    {
        BodyTypeEndomorph_Value = new_value;
    }
}
