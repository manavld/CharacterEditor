using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingBlendshapesFemale : MonoBehaviour
{
    public GameObject Jacket, Dress, TankTop, TShirt, Shorts, Jeans, Joggers;

    private float BodyTypeEctomorph_Value = .0f;
    private float BodyTypeEndomorph_Value = .0f;
    private float BodyTypeMesomorph_Value = .0f;

    private SkinnedMeshRenderer JacketSMR, DressSMR, TankTopSMR, TShirtSMR, ShortsSMR, JeansSMR, JoggersSMR;

    // Start is called before the first frame update
    void Start()
    {
        JacketSMR = Jacket.GetComponent<SkinnedMeshRenderer>();
        DressSMR = Dress.GetComponent<SkinnedMeshRenderer>();
        TankTopSMR = TankTop.GetComponent<SkinnedMeshRenderer>();
        TShirtSMR = TShirt.GetComponent<SkinnedMeshRenderer>();
        ShortsSMR = Shorts.GetComponent<SkinnedMeshRenderer>();
        JeansSMR = Jeans.GetComponent<SkinnedMeshRenderer>();
        JoggersSMR = Joggers.GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jacket
        JacketSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        JacketSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        JacketSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        //Dress
        DressSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        DressSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        DressSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        //TankTop
        TankTopSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        TankTopSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        TankTopSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        //TShirt
        TShirtSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        TShirtSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        TShirtSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        //Shorts
        ShortsSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        ShortsSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        ShortsSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        ShortsSMR.SetBlendShapeWeight(3, (BodyTypeMesomorph_Value * BodyTypeEndomorph_Value) / 100);
        //Jeans
        JeansSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        JeansSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        JeansSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
        //Joggers
        JoggersSMR.SetBlendShapeWeight(0, BodyTypeMesomorph_Value);
        JoggersSMR.SetBlendShapeWeight(1, BodyTypeEndomorph_Value);
        JoggersSMR.SetBlendShapeWeight(2, BodyTypeEctomorph_Value);
    }

    //SLIDERS CALL
    public void EctomorphValue(float new_value)
    {
        if (new_value >= 0)
        {
            BodyTypeMesomorph_Value = new_value;
            BodyTypeEctomorph_Value = 0;
        }
        else if (new_value <= 0)
        {
            BodyTypeEctomorph_Value = -new_value;
            BodyTypeMesomorph_Value = 0;
        }
    }
    public void EndomorphValue(float new_value)
    {
        BodyTypeEndomorph_Value = new_value;
    }
}
