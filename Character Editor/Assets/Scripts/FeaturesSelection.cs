using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeaturesSelection : MonoBehaviour
{
    public Button Body;
    public Button Head;
    public Button Nose;
    public Button Ear;
    public Button Chin;
    public Button Mouth;
    public Button Eyes;

    public Button Randomize, Next;

    //public Button BackToFeatureSelection;
    //public Button BackToMenu;

    public GameObject BodyWindow;
    public GameObject HeadWindow;
    public GameObject NoseWindow;
    public GameObject EarWindow;
    public GameObject ChinWindow;
    public GameObject MouthWindow;
    public GameObject EyesWindow;



   



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
        this.transform.parent.gameObject.SetActive(false);

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
}
