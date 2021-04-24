using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendshapesOther : MonoBehaviour
{
    //all blendshapes
    private float BodyTypeEctomorph_Slider = .0f;
    private float BodyTypeEndomorph_Slider = .0f;


    private SkinnedMeshRenderer SMR;


    // Start is called before the first frame update
    void Start()
    {
        SMR = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Slider);
        SMR.SetBlendShapeWeight(3, BodyTypeEndomorph_Slider);
        //Combination Fix
        SMR.SetBlendShapeWeight(4, (BodyTypeEctomorph_Slider * BodyTypeEndomorph_Slider) / 100);
      
    }




    //---------------------------

    //UPDATE ALL SLIDERS
    public void EctomorphValue(float new_value)
    {
        BodyTypeEctomorph_Slider = new_value;
    }
    public void EndomorphhValue(float new_value)
    {
        BodyTypeEndomorph_Slider = new_value;
    }
}
