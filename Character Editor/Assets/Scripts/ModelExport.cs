using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Autodesk.Fbx;
using UnityEditor.Formats.Fbx.Exporter;

public class ModelExport : MonoBehaviour
{
    public GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEXPORT()
    {
        ModelExporter.ExportObject(Application.dataPath + "ExportedModel.fbx", model);

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
