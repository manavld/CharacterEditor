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

    //Part2
    public Button Hair, EyeColor, SkinTone, TopClothing, BottomClothing, Shoes;

    public GameObject HairWindow, EyeColorWindow, SkinToneWindow, TopClothingWindow, BottomClothingWindow, ShoesWindow;

    public Button NextToExport, BackToPart1;

    public GameObject Part2Title;
    

    private void Awake()
    {
        BodyWindow = canvas.transform.Find("BodyTypesWindow").gameObject;
        HeadWindow = canvas.transform.Find("HeadShapeWindow").gameObject;
        NoseWindow = canvas.transform.Find("NoseWindow").gameObject;
        EarWindow = canvas.transform.Find("EarWindow").gameObject;
        ChinWindow = canvas.transform.Find("ChinWindow").gameObject;
        MouthWindow = canvas.transform.Find("MouthWindow").gameObject;
        EyesWindow = canvas.transform.Find("EyesWindow").gameObject;
        /*
        HairWindow = canvas.transform.Find("HairWindow").gameObject;
        EyeColorWindow = canvas.transform.Find("EyeColorWindow").gameObject;
        SkinToneWindow = canvas.transform.Find("SkinToneWindow").gameObject;
        TopClothingWindow = canvas.transform.Find("TopClothingWindow").gameObject;
        BottomClothingWindow = canvas.transform.Find("BottomClothingWindow").gameObject;
        ShoesWindow = canvas.transform.Find("ShoesWindow").gameObject;
        */
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
        Part2Title.gameObject.SetActive(false);
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

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

    public void SelectionPart2()
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
        Export.gameObject.SetActive(false);
        HairWindow.gameObject.SetActive(false);
        EyeColorWindow.gameObject.SetActive(false);
        SkinToneWindow.gameObject.SetActive(false);
        TopClothingWindow.gameObject.SetActive(false);
        BottomClothingWindow.gameObject.SetActive(false);
        ShoesWindow.gameObject.SetActive(false);

        Part2Title.gameObject.SetActive(true);
        Hair.gameObject.SetActive(true);
        EyeColor.gameObject.SetActive(true);
        SkinTone.gameObject.SetActive(true);
        TopClothing.gameObject.SetActive(true);
        BottomClothing.gameObject.SetActive(true);
        Shoes.gameObject.SetActive(true);
        NextToExport.gameObject.SetActive(true);
        BackToPart1.gameObject.SetActive(true);
    }

    public void OnClickHair()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        HairWindow.gameObject.SetActive(true);
    }

    public void OnClickEyeColor()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        EyeColorWindow.gameObject.SetActive(true);
    }

    public void OnClickSkinTone()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        SkinToneWindow.gameObject.SetActive(true);
    }

    public void OnClickTopClothing()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        TopClothingWindow.gameObject.SetActive(true);
    }

    public void OnClickBottomClothing()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        BottomClothingWindow.gameObject.SetActive(true);
    }

    public void OnClickShoes()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);

        ShoesWindow.gameObject.SetActive(true);
    }

    public void GoToExport()
    {
        Hair.gameObject.SetActive(false);
        EyeColor.gameObject.SetActive(false);
        SkinTone.gameObject.SetActive(false);
        TopClothing.gameObject.SetActive(false);
        BottomClothing.gameObject.SetActive(false);
        Shoes.gameObject.SetActive(false);
        NextToExport.gameObject.SetActive(false);
        BackToPart1.gameObject.SetActive(false);
        Part2Title.gameObject.SetActive(false);

        Export.transform.Find("Information").gameObject.SetActive(false);
        Export.gameObject.SetActive(true);
    }

}
