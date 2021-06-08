using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingBlendshapesMale : MonoBehaviour
{
    public GameObject Jacket, Shirt, TankTop, TShirt, Shorts, Jeans, Joggers;

    private float BodyTypeEctomorph_Value = .0f;
    private float BodyTypeEndomorph_Value = .0f;

    private SkinnedMeshRenderer JacketSMR, ShirtSMR, TankTopSMR, TShirtSMR, ShortsSMR, JeansSMR, JoggersSMR;

    // Start is called before the first frame update
    void Start()
    {
        JacketSMR = Jacket.GetComponent<SkinnedMeshRenderer>();
        ShirtSMR = Shirt.GetComponent<SkinnedMeshRenderer>();
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
        JacketSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        JacketSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        JacketSMR.SetBlendShapeWeight(2, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
        //Shirt
        ShirtSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        ShirtSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        ShirtSMR.SetBlendShapeWeight(2, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
        //TankTop
        TankTopSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        TankTopSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        //TShirt
        TShirtSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        TShirtSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        //Shorts
        ShortsSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        ShortsSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        ShortsSMR.SetBlendShapeWeight(2, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
        //Jeans
        JeansSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        JeansSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        JeansSMR.SetBlendShapeWeight(2, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
        //Joggers
        JoggersSMR.SetBlendShapeWeight(0, BodyTypeEndomorph_Value);
        JoggersSMR.SetBlendShapeWeight(1, BodyTypeEctomorph_Value);
        JoggersSMR.SetBlendShapeWeight(2, (BodyTypeEctomorph_Value * BodyTypeEndomorph_Value) / 100);
        
    }



    //SLIDER CALL
    public void EctomorphSlider(float new_value)
    {
        BodyTypeEctomorph_Value = new_value;
    }
    public void EndomorphSlider(float new_value)
    {
        BodyTypeEndomorph_Value = new_value;
    }

}
