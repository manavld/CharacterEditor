using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeaturesSelection : MonoBehaviour
{
    public GameObject canvas;
    public Button Body;
    public Button Head;
    public Button Nose;
    public Button Ear;
    public Button Chin;
    public Button Mouth;
    public Button Eyes;

    public Button Randomize, Next, Export;

    //public Button BackToFeatureSelection;
    //public Button BackToMenu;

    public static GameObject BodyWindow;
    public static GameObject HeadWindow;
    public static GameObject NoseWindow;
    public static GameObject EarWindow;
    public static GameObject ChinWindow;
    public static GameObject MouthWindow;
    public static GameObject EyesWindow;

    private void Awake()
    {
        BodyWindow = canvas.transform.Find("BodyTypesWindow").gameObject;
        HeadWindow = canvas.transform.Find("HeadShapeWindow").gameObject;
        NoseWindow = canvas.transform.Find("NoseWindow").gameObject;
        EarWindow = canvas.transform.Find("EarWindow").gameObject;
        ChinWindow = canvas.transform.Find("ChinWindow").gameObject;
        MouthWindow = canvas.transform.Find("MouthWindow").gameObject;
        EyesWindow = canvas.transform.Find("EyesWindow").gameObject;
    }

    private void Start()
    {
        /*
        BodyWindow = canvas.transform.Find("BodyTypesWindow").gameObject;
        HeadWindow = canvas.transform.Find("HeadShapeWindow").gameObject;
        NoseWindow = canvas.transform.Find("NoseWindow").gameObject;
        EarWindow = canvas.transform.Find("EarWindow").gameObject;
        ChinWindow = canvas.transform.Find("ChinWindow").gameObject;
        MouthWindow = canvas.transform.Find("MouthWindow").gameObject;
        EyesWindow = canvas.transform.Find("EyesWindow").gameObject;
        */
        
        BodyWindow.gameObject.SetActive(false);
        HeadWindow.gameObject.SetActive(false);
        NoseWindow.gameObject.SetActive(false);
        EarWindow.gameObject.SetActive(false);
        ChinWindow.gameObject.SetActive(false);
        MouthWindow.gameObject.SetActive(false);
        EyesWindow.gameObject.SetActive(false);
        
    }

    



    public void OnClickBODY()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        BodyWindow.gameObject.SetActive(true);
    }

    public void OnClickHEAD()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        HeadWindow.gameObject.SetActive(true);
    }

    public void OnClickNOSE()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        NoseWindow.gameObject.SetActive(true);
    }

    public void OnClickEAR()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        EarWindow.gameObject.SetActive(true);
    }

    public void OnClickCHIN()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        ChinWindow.gameObject.SetActive(true);
    }

    public void OnClickMOUTH()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        MouthWindow.gameObject.SetActive(true);
    }

    public void OnClickEYES()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        EyesWindow.gameObject.SetActive(true);
    }

    public void BackToSelection()
    {
        BodyWindow.gameObject.SetActive(false);
        HeadWindow.gameObject.SetActive(false);
        NoseWindow.gameObject.SetActive(false);
        EarWindow.gameObject.SetActive(false);
        ChinWindow.gameObject.SetActive(false);
        MouthWindow.gameObject.SetActive(false);
        EyesWindow.gameObject.SetActive(false);
        Export.gameObject.SetActive(false);

        Body.gameObject.SetActive(true);
        Head.gameObject.SetActive(true);
        Nose.gameObject.SetActive(true);
        Ear.gameObject.SetActive(true);
        Chin.gameObject.SetActive(true);
        Mouth.gameObject.SetActive(true);
        Eyes.gameObject.SetActive(true);
        Randomize.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);

    }

    public void GoToExport()
    {
        Body.gameObject.SetActive(false);
        Head.gameObject.SetActive(false);
        Nose.gameObject.SetActive(false);
        Ear.gameObject.SetActive(false);
        Chin.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        Eyes.gameObject.SetActive(false);
        Randomize.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

        Export.gameObject.SetActive(true);
    }
}
