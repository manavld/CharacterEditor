using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_BlendshapesEyes : MonoBehaviour
{
    //all blendshapes
    private float Eyes_Narrow_Value = .0f;
    private float Eyes_Wide_Value = .0f;

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
        else if (new_value <= 0)
        {
            Eyes_Narrow_Value = -new_value;
            Eyes_Wide_Value = 0;
        }
    }

}
