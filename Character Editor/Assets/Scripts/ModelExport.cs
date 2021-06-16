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

    // Start is called before the first frame update
    void Start()
    {
        //Body
        Body = model.transform.GetChild(0).gameObject;
        Other = model.transform.GetChild(1).gameObject;
        if (model.name == "Female_LP_BlendShapes")
            Extra = model.transform.GetChild(2).gameObject;

        //Hair Meshes
        Beard = Hair.transform.GetChild(0).gameObject;
        BackComb = Hair.transform.GetChild(1).gameObject;
        Messy = Hair.transform.GetChild(2).gameObject;
        MiddleComb = Hair.transform.GetChild(3).gameObject;
        Ponytail = Hair.transform.GetChild(4).gameObject;
        ShavedSide = Hair.transform.GetChild(5).gameObject;
        Short = Hair.transform.GetChild(6).gameObject;
        Mustache = Hair.transform.GetChild(7).gameObject;

        //TopClothes Meshes
        TShirt = Clothing.transform.GetChild(0).gameObject;
        TankTop = Clothing.transform.GetChild(1).gameObject;
        Shirt = Clothing.transform.GetChild(2).gameObject;
        Jacket = Clothing.transform.GetChild(3).gameObject;
        Shorts = Clothing.transform.GetChild(4).gameObject;
        Jeans = Clothing.transform.GetChild(5).gameObject;
        Joggers = Clothing.transform.GetChild(6).gameObject;
        Converse = Clothing.transform.GetChild(7).gameObject;
        DC = Clothing.transform.GetChild(8).gameObject;
        Formal = Clothing.transform.GetChild(9).gameObject;

        backExport = export.transform.Find("BackButton").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        
        //Beard.transform.parent = HairInactive.transform;
    }

    public void ExportTexture(Texture2D t)
    {
        Texture2D exTexture = new Texture2D(t.width, t.height, TextureFormat.RGBA32, false);
        exTexture.SetPixels(t.GetPixels());
        string fileName = $"{t.name}.png";
        //exportName = textureFolder + "\\" + fileName;
        System.IO.File.WriteAllBytes(Application.dataPath + fileName, exTexture.EncodeToPNG());
    }

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
        //FBXExporter.ExportGameObjToFBX(model, Application.dataPath + "EXPORTED_MODEL.fbx", true, true);


        //export materials
        if (model.name == "Male_LP_BlendShapes") { 
             //Skin
             ExportTexture(Body.GetComponent<Renderer>().material.mainTexture as Texture2D);

             //Other
             ExportTexture(Other.GetComponent<Renderer>().material.mainTexture as Texture2D);

        }   
        if (model.name == "Female_LP_BlendShapes") { 
             //Skin
             ExportTexture(Body.GetComponent<Renderer>().material.mainTexture as Texture2D);

             //Other
             ExportTexture(Other.GetComponent<Renderer>().material.mainTexture as Texture2D);

             //Extra
             ExportTexture(Extra.GetComponent<Renderer>().material.mainTexture as Texture2D);
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
        //clothes
        if (TShirt.activeSelf == true)
        {
            ExportTexture(TShirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (TankTop.activeSelf == true)
        {
            ExportTexture(TankTop.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Jacket.activeSelf == true)
        {
            ExportTexture(Jacket.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Shirt.activeSelf == true) //Dress or shirt TODO
        {
            ExportTexture(Shirt.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Shorts.activeSelf == true)
        {
            ExportTexture(Shorts.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Jeans.activeSelf == true)
        {
            ExportTexture(Jeans.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Joggers.activeSelf == true)
        {
            ExportTexture(Joggers.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Converse.activeSelf == true)
        {
            ExportTexture(Converse.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (DC.activeSelf == true)
        {
            ExportTexture(DC.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }
        if (Formal.activeSelf == true) //Crocs or Formal TODO
        {
            ExportTexture(Formal.GetComponent<Renderer>().material.mainTexture as Texture2D);
        }

        //info text
        export.transform.Find("Information").gameObject.SetActive(true);


        //Set back to initial rotation
        model.transform.localEulerAngles = new Vector3(0, 165, 0);
        backExport.SetActive(false);

        /*
        //Put back inactive meshes
        //hair
        BackComb.transform.parent = Hair.transform;
        BackComb.transform.localEulerAngles = new Vector3(0, 0, 0);
        Messy.transform.parent = Hair.transform;
        Messy.transform.localEulerAngles = new Vector3(0, 0, 0);
        MiddleComb.transform.parent = Hair.transform;
        MiddleComb.transform.rotation = Quaternion.identity;
        Ponytail.transform.parent = Hair.transform;
        Ponytail.transform.rotation = Quaternion.identity;
        ShavedSide.transform.parent = Hair.transform;
        ShavedSide.transform.rotation = Quaternion.identity;
        Short.transform.parent = Hair.transform;
        Short.transform.rotation = Quaternion.identity;
        Mustache.transform.parent = Hair.transform;
        Mustache.transform.rotation = Quaternion.identity;
        Beard.transform.parent = Hair.transform;
        Beard.transform.rotation = Quaternion.identity;

        //clothes
        TShirt.transform.parent = Clothing.transform;
        TShirt.transform.rotation = Quaternion.identity;
        TankTop.transform.parent = Clothing.transform;
        TankTop.transform.rotation = Quaternion.identity;
        Jacket.transform.parent = Clothing.transform;
        Jacket.transform.rotation = Quaternion.identity;
        Shirt.transform.parent = Clothing.transform;
        Shirt.transform.rotation = Quaternion.identity;
        Shorts.transform.parent = Clothing.transform;
        Shorts.transform.rotation = Quaternion.identity;
        Jeans.transform.parent = Clothing.transform;
        Jeans.transform.rotation = Quaternion.identity;
        Joggers.transform.parent = Clothing.transform;
        Joggers.transform.rotation = Quaternion.identity;
        Converse.transform.parent = Clothing.transform;
        Converse.transform.rotation = Quaternion.identity;
        DC.transform.parent = Clothing.transform;
        DC.transform.rotation = Quaternion.identity;
        Formal.transform.parent = Clothing.transform;
        Formal.transform.rotation = Quaternion.identity;
        */


        //ModelExporter.ExportObject(Application.dataPath + "ExportedModel.fbx", model);



        /*
        using (FbxManager fbxManager = FbxManager.Create())
        {
            // configure IO settings.
            fbxManager.SetIOSettings(FbxIOSettings.Create(fbxManager, Globals.IOSROOT));

            // Export the scene
            using (FbxExporter exporter = FbxExporter.Create(fbxManager, "myExporter"))
            {

                // Initialize the exporter.
                bool status = exporter.Initialize("exported.fbx", -1, fbxManager.GetIOSettings());

                // Create a new scene to export
                FbxScene scene = FbxScene.Create(fbxManager, "Male");

                // Export the scene to the file.
                exporter.Export(scene);
            }
        }
        */

    }


   
}
