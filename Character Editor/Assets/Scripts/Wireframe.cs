using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wireframe : MonoBehaviour
{
    public Camera main;
    public Camera wireframe;
    private bool wireframeOn = false;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPreRender()
    {
        GL.wireframe = true;
    }
    void OnPostRender()
    {
        GL.wireframe = false;
    }


    public void SwitchWireframe()
    {
        if (wireframeOn == false)
        {
            main.gameObject.SetActive(false);
            wireframe.gameObject.SetActive(true);
            wireframeOn = true;
        }
        else if (wireframeOn == true)
        {
            main.gameObject.SetActive(true);
            wireframe.gameObject.SetActive(false);
            wireframeOn = false;
        }

    }
}
