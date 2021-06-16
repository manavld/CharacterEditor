using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.Formats.Fbx.Exporter;
//using Autodesk.Fbx;
//using FE = UnityFBXExporter.FBXExporter;
using UnityFBXExporter;

public class ModelExport : MonoBehaviour
{
    private MultipleMeshMale male;
    public GameObject model;
    public GameObject export;
    private GameObject backExport;
    private GameObject Body, Other, Extra;

    public GameObject Clothing, Hair;
    private GameObject Jacket, Shirt, TankTop, TShirt, Shorts, Jeans, Joggers, Converse, DC, Formal;
    private GameObject Beard, BackComb, Messy, MiddleComb, Ponytail, ShavedSide, Short, Mustache;
    public GameObject ClothesInactive, HairInactive;

    //Other textures

    //body
    public Texture2D BodyNormal, BodyHeight, BodyMetallic, BodyAO, BodyRoughness;
    public Texture2D OtherNormal, OtherHeight, OtherMetallic, OtherRoughness;
    public Texture2D ExtraNormal, ExtraHeight, ExtraMetallic, ExtraRoughness;
    //clothes
    public Texture2D ShirtNormal, ShirtAO, ShirtMetallic, ShirtHeight;
    public Texture2D JacketNormal, JacketAO, JacketMetallic, JacketHeight, JacketRoughness;
    public Texture2D TShirtNormal, TShirtRoughness, TShirtMetallic, TShirtHeight; 
    public Texture2D TanktopNormal, TanktopAO, TanktopMetallic, TanktopHeight;
    public Texture2D JeansNormal, JeansMetallic, JeansHeight, JeansRoughness;
    public Texture2D JoggersNormal, JoggersAO, JoggersRoughness, JoggersHeight;
    public Texture2D ShortsNormal;
    public Texture2D ConverseNormal, ConverseAO, ConverseMetallic, ConverseHeight;
    public Texture2D DCNormal, DCAO, DCHeight;
    public Texture2D FormalNormal, FormalRoughness, FormalMetallic, FormalHeight;

    // Start is called before the first frame update
    void Start()
    {
        //Body
        Body = model.transform.GetChild(0).gameObject;
        Other = model.transform.GetChild(1).gameObject;
        if (model.name == "Female_LP_BlendShapes")
            Extra = model.transform.GetChild(2).gameObject;

        //Hair Meshes
        Beard = Hair.transform.GetChild(0).gameObject;      //long
        BackComb = Hair.transform.GetChild(1).gameObject;
        Messy = Hair.transform.GetChild(2).gameObject;
        MiddleComb = Hair.transform.GetChild(3).gameObject;
        Ponytail = Hair.transform.GetChild(4).gameObject;
        ShavedSide = Hair.transform.GetChild(5).gameObject;
        Short = Hair.transform.GetChild(6).gameObject;
        Mustache = Hair.transform.GetChild(7).gameObject;    //ponytailx2

        //TopClothes Meshes
        TShirt = Clothing.transform.GetChild(0).gameObject;
        TankTop = Clothing.transform.GetChild(1).gameObject;
        Shirt = Clothing.transform.GetChild(2).gameObject;     //Dress
        Jacket = Clothing.transform.GetChild(3).gameObject;
        Shorts = Clothing.transform.GetChild(4).gameObject;
        Jeans = Clothing.transform.GetChild(5).gameObject;
        Joggers = Clothing.transform.GetChild(6).gameObject;
        Converse = Clothing.transform.GetChild(7).gameObject;
        DC = Clothing.transform.GetChild(8).gameObject;
        Formal = Clothing.transform.GetChild(9).gameObject;     //Crocs

        backExport = export.transform.Find("BackButton").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExportTexture(Texture2D t)
    {
        Texture2D exTexture = new Texture2D(t.width, t.height, TextureFormat.RGBA32, false);
        exTexture.SetPixels(t.GetPixels());
        string fileName = $"{t.name}.png";
        //exportName = textureFolder + "\\" + fileName;
        System.IO.File.WriteAllBytes(Application.dataPath + fileName, exTexture.EncodeToPNG());
    }
    /*
    public void ExportNormal(Texture2D t)
    {
        Texture2D exTexture = new Texture2D(t.width, t.height, TextureFormat.RGBA32, false, true);
        exTexture.SetPixels(t.GetPixels());
        string fileName = $"{t.name}.png";
        //exportName = textureFolder + "\\" + fileName;
        System.IO.File.WriteAllBytes(Application.dataPath + fileName, exTexture.EncodeToPNG());
    }
    */
    

    public void OnClickEXPORT()
    {
        //Set rotation 0
        model.transform.rotation = Quaternion.identity;

        //Deleting inactive

        //hair
        if (BackComb.activeSelf == false)
            BackComb.transform.parent = HairInactive.transform;
        if (Messy.activeSelf == false)
            Messy.transform.parent = HairInactive.transform;
        if (MiddleComb.activeSelf == false)
            MiddleComb.transform.parent = HairInactive.transform;
        if (Ponytail.activeSelf == false)
            Ponytail.transform.parent = HairInactive.transform;
        if (ShavedSide.activeSelf == false)
            ShavedSide.transform.parent = HairInactive.transform;
        if (Short.activeSelf == false)
            Short.transform.parent = HairInactive.transform;
        if (Mustache.activeSelf == false)
            Mustache.transform.parent = HairInactive.transform;
        if (Beard.activeSelf == false)
            Beard.transform.parent = HairInactive.transform;

        //clothes
        if (TShirt.activeSelf == false)
            TShirt.transform.parent = ClothesInactive.transform;
        if (TankTop.activeSelf == false)
            TankTop.transform.parent = ClothesInactive.transform;
        if (Jacket.activeSelf == false)
            Jacket.transform.parent = ClothesInactive.transform;
        if (Shirt.activeSelf == false)
            Shirt.transform.parent = ClothesInactive.transform;
        if (Shorts.activeSelf == false)
            Shorts.transform.parent = ClothesInactive.transform;
        if (Jeans.activeSelf == false)
            Jeans.transform.parent = ClothesInactive.transform;
        if (Joggers.activeSelf == false)
            Joggers.transform.parent = ClothesInactive.transform;
        if (Converse.activeSelf == false)
            Converse.transform.parent = ClothesInactive.transform;
        if (DC.activeSelf == false)
            DC.transform.parent = ClothesInactive.transform;
        if (Formal.activeSelf == false)
            Formal.transform.parent = ClothesInactive.transform;

        //fbx
        FBXExporter.ExportGameObjToFBX(model, Application.dataPath + "EXPORTED_MODEL.fbx", false, true);


        //export materials
        if (model.name == "Male_LP_BlendShapes") { 
            //Skin
            ExportTexture(Body.GetComponent<Renderer>().material.mainTexture as Texture2D);
            ExportTexture(BodyHeight);
            ExportTexture(BodyNormal);
            ExportTexture(BodyMetallic);
            ExportTexture(BodyAO);
            //Other
            ExportTexture(Other.GetComponent<Renderer>().material.mainTexture as Texture2D);
            ExportTexture(OtherHeight);
            ExportTexture(OtherNormal);
            ExportTexture(OtherMetallic);
            ExportTexture(OtherRoughness);
            //clothes
            if (TShirt.activeSelf == true)
            {
                ExportTexture(TShirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(TShirtNormal);
                ExportTexture(TShirtMetallic);
                ExportTexture(TShirtRoughness);
                ExportTexture(TShirtHeight);
            }
            if (TankTop.activeSelf == true)
            {
                ExportTexture(TankTop.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(TanktopHeight);
                ExportTexture(TanktopNormal);
                ExportTexture(TanktopMetallic);
                ExportTexture(TanktopAO);
            }
            if (Jacket.activeSelf == true)
            {
                ExportTexture(Jacket.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JacketNormal);
                ExportTexture(JacketRoughness);
            }
            if (Shirt.activeSelf == true) 
            {
                ExportTexture(Shirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ShirtAO);
                ExportTexture(ShirtNormal);
                ExportTexture(ShirtMetallic);
                ExportTexture(ShirtHeight);
            }
            if (Shorts.activeSelf == true)
            {
                ExportTexture(Shorts.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ShortsNormal);
            }
            if (Jeans.activeSelf == true)
            {
                ExportTexture(Jeans.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JeansHeight);
                ExportTexture(JeansNormal);
                ExportTexture(JeansMetallic);
                ExportTexture(JeansRoughness);
            }
            if (Joggers.activeSelf == true)
            {
                ExportTexture(Joggers.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JoggersHeight);
                ExportTexture(JoggersNormal);
                ExportTexture(JoggersAO);
                ExportTexture(JoggersRoughness);
            }
            if (Converse.activeSelf == true)
            {
                ExportTexture(Converse.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ConverseHeight);
                ExportTexture(ConverseNormal);
                ExportTexture(ConverseAO);
                ExportTexture(ConverseMetallic);
            }
            if (DC.activeSelf == true)
            {
                ExportTexture(DC.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(DCHeight);
                ExportTexture(DCNormal);
                ExportTexture(DCAO);
            }
            if (Formal.activeSelf == true) 
            {
                ExportTexture(Formal.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(FormalHeight);
                ExportTexture(FormalNormal);
                ExportTexture(FormalMetallic);
            }
        }   
        if (model.name == "Female_LP_BlendShapes") { 
            //Skin
            ExportTexture(Body.GetComponent<Renderer>().material.mainTexture as Texture2D);
            ExportTexture(BodyHeight);
            ExportTexture(BodyNormal);
            ExportTexture(BodyMetallic);
            ExportTexture(BodyAO);
            ExportTexture(BodyRoughness);
            //Other
            ExportTexture(Other.GetComponent<Renderer>().material.mainTexture as Texture2D);
            ExportTexture(OtherHeight);
            ExportTexture(OtherNormal);
            ExportTexture(OtherMetallic);
            ExportTexture(OtherRoughness);
            //Extra
            ExportTexture(Extra.GetComponent<Renderer>().material.mainTexture as Texture2D);
            ExportTexture(ExtraHeight);
            ExportTexture(ExtraNormal);
            ExportTexture(ExtraMetallic);
            ExportTexture(ExtraRoughness);
            //clothes
            if (TShirt.activeSelf == true)
            {
                ExportTexture(TShirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(TShirtNormal);
                ExportTexture(TShirtMetallic);
            }
            if (TankTop.activeSelf == true)
            {
                ExportTexture(TankTop.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(TanktopHeight);
                ExportTexture(TanktopNormal);
                ExportTexture(TanktopMetallic);
                ExportTexture(TanktopAO);
            }
            if (Jacket.activeSelf == true)
            {
                ExportTexture(Jacket.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JacketHeight);
                ExportTexture(JacketNormal);
                ExportTexture(JacketMetallic);
                ExportTexture(JacketAO);
                ExportTexture(JacketRoughness);
            }
            if (Shirt.activeSelf == true) //Dress 
            {
                ExportTexture(Shirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ShirtAO);
            }
            if (Shorts.activeSelf == true)
            {
                ExportTexture(Shorts.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ShortsNormal);
            }
            if (Jeans.activeSelf == true)
            {
                ExportTexture(Jeans.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JeansHeight);
                ExportTexture(JeansNormal);
                ExportTexture(JeansMetallic);
                ExportTexture(JeansRoughness);
            }
            if (Joggers.activeSelf == true)
            {
                ExportTexture(Joggers.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(JoggersHeight);
                ExportTexture(JoggersNormal);
                ExportTexture(JoggersAO);
                ExportTexture(JoggersRoughness);
            }
            if (Converse.activeSelf == true)
            {
                ExportTexture(Converse.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(ConverseHeight);
                ExportTexture(ConverseNormal);
                ExportTexture(ConverseAO);
                ExportTexture(ConverseMetallic);
            }
            if (DC.activeSelf == true)
            {
                ExportTexture(DC.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(DCHeight);
                ExportTexture(DCNormal);
                ExportTexture(DCAO);
            }
            if (Formal.activeSelf == true) //Crocs 
            {
                ExportTexture(Formal.GetComponent<Renderer>().material.mainTexture as Texture2D);
                ExportTexture(FormalHeight);
                ExportTexture(FormalNormal);
                ExportTexture(FormalMetallic);
                ExportTexture(FormalRoughness);
            }
        }   

        //hair
        if (BackComb.activeSelf == true)
        {
            ExportTexture(BackComb.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Messy.activeSelf == true)
        {
            ExportTexture(Messy.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (MiddleComb.activeSelf == true)
        {
            ExportTexture(MiddleComb.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Ponytail.activeSelf == true)
        {
            ExportTexture(Ponytail.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (ShavedSide.activeSelf == true)
        {
            ExportTexture(ShavedSide.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Short.activeSelf == true)
        {
            ExportTexture(Short.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Mustache.activeSelf == true)
        {
            ExportTexture(Mustache.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Beard.activeSelf == true)
        {
            ExportTexture(Beard.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
       

        //info text
        export.transform.Find("Information").gameObject.SetActive(true);


        //Set back to initial rotation
        model.transform.localEulerAngles = new Vector3(0, 165, 0);
        backExport.SetActive(false);

        

    }


   
}
