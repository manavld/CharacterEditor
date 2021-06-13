using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultipleMeshMale : MonoBehaviour
{
    //Parents
    public GameObject Body, Other, Clothing, Hair, HairWindow, EyeWindow, SkinWindow, TopWindow, BottomWindow, ShoesWindow;
    //all clothes
    private GameObject Jacket, Shirt, TankTop, TShirt, Shorts, Jeans, Joggers, Converse, DC, Formal;
    private int TopClothingList = 0;
    private int BottomClothingList = 0;
    private int ShoesList = 0;
    //all hairstyles
    private GameObject Beard, BackComb, Messy, MiddleComb, Ponytail, ShavedSide, Short, Mustache;
    private int HairList = 0;
    private int FacialHairList = 0;

    //HairWindow
    private GameObject HairCurrent, FacialHairCurrent;

    //TopClothing Window
    private GameObject TopClothesCurrent;
    private GameObject TopBlack, TopWhite, TopLBlue, TopRed, TopGreen, TopGrey, TopPink, TopDBlue, TopBrown, TopCamo;

    //BottomClothing Window
    private GameObject BottomClothesCurrent;

    //Shoes Window
    private GameObject ShoesCurrent;


    //Textures---------
    //Skin
    private Texture SkinTex1, SkinTex2, SkinTex3, SkinTex4, SkinTex5, SkinTex6, SkinTex7;

    //Eyes
    private Texture EyeLBrownTex, EyeGreenTex, EyeLGreenTex, EyeBlueTex, EyeLBlueTex, EyeHazelTex, EyeBrownTex;

    //Hair 
    private Texture HairBlackT, HairBlackT2, HairBlackT3;
    private Texture HairBlondeT, HairBlondeT2, HairBlondeT3;
    private Texture HairBlueT, HairBlueT2, HairBlueT3;
    private Texture HairBrownT, HairBrownT2, HairBrownT3, HairBrownT4;
    private Texture HairGreenT, HairGreenT2, HairGreenT3;
    private Texture HairGreyT, HairGreyT2, HairGreyT3;
    private Texture HairPinkT, HairPinkT2, HairPinkT3;
    private Texture HairRedT, HairRedT2, HairRedT3;

    //TopClothing
    private Texture TShirtGreyTex, TShirtBlackTex, TShirtWhiteTex, TShirtBlueTex, TShirtRedTex, TShirtDBlueTex, TShirtGreenTex, TShirtPinkTex, TShirtCamoTex;
    private Texture TanktopDBlueT, TanktopBlackT, TanktopWhiteT, TanktopLBlueT, TanktopRedT, TanktopPinkT, TanktopGreenT;
    private Texture ShirtWhiteT, ShirtBlackT, ShirtDBlueT, ShirtRedT, ShirtGreyT, ShirtGreenT, ShirtPinkT, ShirtLBlueT;
    private Texture JacketBrownT, JacketBlackT, JacketWhiteT, JacketDBlueT, JacketRedT, JacketGreyT;
    // Start is called before the first frame update
    void Start()
    {
        //Hair Meshes
        Beard = Hair.transform.Find("M_Beard").gameObject;
        BackComb = Hair.transform.Find("M_HairBackComb").gameObject;
        Messy = Hair.transform.Find("M_HairMessy").gameObject;
        MiddleComb = Hair.transform.Find("M_HairMiddleComb").gameObject;
        Ponytail = Hair.transform.Find("M_HairPonytail").gameObject;
        ShavedSide = Hair.transform.Find("M_HairShavedSide").gameObject;
        Short = Hair.transform.Find("M_HairShort").gameObject;
        Mustache = Hair.transform.Find("M_Mustache").gameObject;

        //Hair Window
        HairCurrent = HairWindow.transform.Find("HairCurrent").gameObject;
        FacialHairCurrent = HairWindow.transform.Find("FacialHairCurrent").gameObject;

        //TopClothes Meshes
        TShirt = Clothing.transform.Find("M_TShirt").gameObject;
        TankTop = Clothing.transform.Find("M_TankTop").gameObject;
        Shirt = Clothing.transform.Find("M_Shirt").gameObject;
        Jacket = Clothing.transform.Find("M_Jacket").gameObject;

        //TopClothing Window
        TopClothesCurrent = TopWindow.transform.Find("TopClothesCurrent").gameObject;

        TopBlack = TopWindow.transform.Find("TopClothesBlack").gameObject;
        TopWhite = TopWindow.transform.Find("TopClothesWhite").gameObject;
        TopLBlue = TopWindow.transform.Find("TopClothesLBlue").gameObject;
        TopRed = TopWindow.transform.Find("TopClothesRed").gameObject;
        TopGreen = TopWindow.transform.Find("TopClothesGreen").gameObject;
        TopGrey = TopWindow.transform.Find("TopClothesGrey").gameObject;
        TopPink = TopWindow.transform.Find("TopClothesPink").gameObject;
        TopDBlue = TopWindow.transform.Find("TopClothesDBlue").gameObject;
        TopBrown = TopWindow.transform.Find("TopClothesBrown").gameObject;
        TopCamo = TopWindow.transform.Find("TopClothesCamo").gameObject;

        //BottomClothes Meshes
        Shorts = Clothing.transform.Find("M_Shorts").gameObject;
        Jeans = Clothing.transform.Find("M_Jeans").gameObject;
        Joggers = Clothing.transform.Find("M_Joggers").gameObject;

        //BottomClothing Window
        BottomClothesCurrent = BottomWindow.transform.Find("BottomClothesCurrent").gameObject;

        //Shoes Meshes
        Converse = Clothing.transform.Find("M_ShoesConverse").gameObject;
        DC = Clothing.transform.Find("M_ShoesDC").gameObject;
        Formal = Clothing.transform.Find("M_ShoesFormal").gameObject;

        //Shoes Window
        ShoesCurrent = ShoesWindow.transform.Find("ShoesCurrent").gameObject;


        //Textures

        //SkinTone
        SkinTex1 = Resources.Load("Textures/Male/M_Skin_Color1") as Texture2D;
        SkinTex2 = Resources.Load("Textures/Male/M_Skin_Color2") as Texture2D;
        SkinTex3 = Resources.Load("Textures/Male/M_Skin_Color3") as Texture2D;
        SkinTex4 = Resources.Load("Textures/Male/M_Skin_Color4") as Texture2D;
        SkinTex5 = Resources.Load("Textures/Male/M_Skin_Color5") as Texture2D;
        SkinTex6 = Resources.Load("Textures/Male/M_Skin_Color6") as Texture2D;
        SkinTex7 = Resources.Load("Textures/Male/M_Skin_Color7") as Texture2D;

        //EyeColor
        EyeLBrownTex = Resources.Load("Textures/Male/Other_Color1") as Texture2D;
        EyeGreenTex = Resources.Load("Textures/Male/Other_Color2") as Texture2D;
        EyeLGreenTex = Resources.Load("Textures/Male/Other_Color3") as Texture2D;
        EyeBlueTex = Resources.Load("Textures/Male/Other_Color4") as Texture2D;
        EyeLBlueTex = Resources.Load("Textures/Male/Other_Color5") as Texture2D;
        EyeHazelTex = Resources.Load("Textures/Male/Other_Color6") as Texture2D;
        EyeBrownTex = Resources.Load("Textures/Male/Other_Color7") as Texture2D;

        //HairColor
        HairBlackT = Resources.Load("Hair/Long/hairblackT") as Texture2D;
        HairBlondeT = Resources.Load("Hair/Long/hairblondeT") as Texture2D;
        HairBlueT = Resources.Load("Hair/Long/hairblueT") as Texture2D;
        HairBrownT = Resources.Load("Hair/Long/hairbrownT") as Texture2D;
        HairGreenT = Resources.Load("Hair/Long/hairgreenT") as Texture2D;
        HairGreyT = Resources.Load("Hair/Long/hairgreyT") as Texture2D;
        HairPinkT = Resources.Load("Hair/Long/hairpinkT") as Texture2D;
        HairRedT = Resources.Load("Hair/Long/hairredT") as Texture2D;

        HairBlackT2 = Resources.Load("Hair/BackComb/hairblackT2") as Texture2D;
        HairBlondeT2 = Resources.Load("Hair/BackComb/hairblondeT2") as Texture2D;
        HairBlueT2 = Resources.Load("Hair/BackComb/hairblueT2") as Texture2D;
        HairBrownT2 = Resources.Load("Hair/BackComb/hairbrownT2") as Texture2D;
        HairGreenT2 = Resources.Load("Hair/BackComb/hairgreenT2") as Texture2D;
        HairGreyT2 = Resources.Load("Hair/BackComb/hairgreyT2") as Texture2D;
        HairPinkT2 = Resources.Load("Hair/BackComb/hairpinkT2") as Texture2D;
        HairRedT2 = Resources.Load("Hair/BackComb/hairredT2") as Texture2D;

        HairBlackT3 = Resources.Load("Hair/Beard/hairblackT3") as Texture2D;
        HairBlondeT3 = Resources.Load("Hair/Beard/hairblondeT3") as Texture2D;
        HairBlueT3 = Resources.Load("Hair/Beard/hairblueT3") as Texture2D;
        HairBrownT3 = Resources.Load("Hair/Beard/hairbrownT3") as Texture2D;
        HairGreenT3 = Resources.Load("Hair/Beard/hairgreenT3") as Texture2D;
        HairGreyT3 = Resources.Load("Hair/Beard/hairgreyT3") as Texture2D;
        HairPinkT3 = Resources.Load("Hair/Beard/hairpinkT3") as Texture2D;
        HairRedT3 = Resources.Load("Hair/Beard/hairredT3") as Texture2D;

        HairBrownT4 = Resources.Load("Hair/BackComb/HAIRTEXURE1-2") as Texture2D;


        //TShirt
        TShirtGreyTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color1") as Texture2D;
        TShirtBlackTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color2") as Texture2D;
        TShirtWhiteTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color3") as Texture2D;
        TShirtBlueTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color4") as Texture2D;
        TShirtRedTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color5") as Texture2D;
        TShirtDBlueTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color6") as Texture2D;
        TShirtGreenTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color7") as Texture2D;
        TShirtPinkTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color8") as Texture2D;
        TShirtCamoTex = Resources.Load("Clothing/M_Tshirt/M_TShirt_Color9") as Texture2D;
        //Jacket
        JacketBrownT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color1") as Texture2D;
        JacketBlackT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color2") as Texture2D;
        JacketWhiteT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color3") as Texture2D;
        JacketDBlueT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color4") as Texture2D;
        JacketRedT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color5") as Texture2D;
        JacketGreyT = Resources.Load("Clothing/M_Jacket/M_Jacket_Color6") as Texture2D;
        //Shirt
        ShirtWhiteT = Resources.Load("Clothing/M_Shirt/Shirt_Color1") as Texture2D;
        ShirtBlackT = Resources.Load("Clothing/M_Shirt/Shirt_Color2") as Texture2D;
        ShirtDBlueT = Resources.Load("Clothing/M_Shirt/Shirt_Color3") as Texture2D;
        ShirtRedT = Resources.Load("Clothing/M_Shirt/Shirt_Color4") as Texture2D;
        ShirtGreyT = Resources.Load("Clothing/M_Shirt/Shirt_Color5") as Texture2D;
        ShirtGreenT = Resources.Load("Clothing/M_Shirt/Shirt_Color6") as Texture2D;
        ShirtPinkT = Resources.Load("Clothing/M_Shirt/Shirt_Color7") as Texture2D;
        ShirtLBlueT = Resources.Load("Clothing/M_Shirt/Shirt_Color8") as Texture2D;
        //TankTop
        TanktopDBlueT = Resources.Load("Clothing/TankTop/TankTop_Color1") as Texture2D;
        TanktopBlackT = Resources.Load("Clothing/TankTop/TankTop_Color2") as Texture2D;
        TanktopWhiteT = Resources.Load("Clothing/TankTop/TankTop_Color3") as Texture2D;
        TanktopLBlueT = Resources.Load("Clothing/TankTop/TankTop_Color4") as Texture2D;
        TanktopRedT = Resources.Load("Clothing/TankTop/TankTop_Color5") as Texture2D;
        TanktopPinkT = Resources.Load("Clothing/TankTop/TankTop_Color6") as Texture2D;
        TanktopGreenT = Resources.Load("Clothing/TankTop/TankTop_Color7") as Texture2D;


    }

    // Update is called once per frame
    void Update()
    {
        //TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtGreyTex);
       
    }


    //-------------------------------------------------------

    //ALL BUTTON FUNCTIONS



    //Multiple Mesh Functions
    public void HairNext()
    {
        if(HairList < 6)
        {
            HairList++;
        }
        //HairMultipleMesh
        switch (HairList)
        {
            case 0:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                BackComb.SetActive(false);
                //color options

                break;
            case 1:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "BACK COMB";
                //meshes
                BackComb.SetActive(true);
                Messy.SetActive(false);
                //color options

                break;
            case 2:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "MESSY";
                //meshes
                Messy.SetActive(true);
                BackComb.SetActive(false);
                MiddleComb.SetActive(false);
                //color options

                break;
            case 3:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "MIDDLE COMB";
                //meshes
                MiddleComb.SetActive(true);
                Messy.SetActive(false);
                Ponytail.SetActive(false);
                //color options

                break;
            case 4:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "PONYTAIL";
                //meshes
                Ponytail.SetActive(true);
                MiddleComb.SetActive(false);
                ShavedSide.SetActive(false);
                //color options

                break;
            case 5:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "SHAVED SIDES";
                //meshes
                ShavedSide.SetActive(true);
                Short.SetActive(false);
                Ponytail.SetActive(false);
                //color options

                break;
            case 6:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "SHORT";
                //meshes
                Short.SetActive(true);
                ShavedSide.SetActive(false);
                //color options

                break;
        }
    }
    public void HairPrev()
    {
        if (HairList > 0)
        {
            HairList--;
        }
        //HairMultipleMesh
        switch (HairList)
        {
            case 0:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                BackComb.SetActive(false);
                //color options

                break;
            case 1:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "BACK COMB";
                //meshes
                BackComb.SetActive(true);
                Messy.SetActive(false);
                //color options

                break;
            case 2:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "MESSY";
                //meshes
                Messy.SetActive(true);
                BackComb.SetActive(false);
                MiddleComb.SetActive(false);
                //color options

                break;
            case 3:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "MIDDLE COMB";
                //meshes
                MiddleComb.SetActive(true);
                Messy.SetActive(false);
                Ponytail.SetActive(false);
                //color options

                break;
            case 4:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "PONYTAIL";
                //meshes
                Ponytail.SetActive(true);
                MiddleComb.SetActive(false);
                ShavedSide.SetActive(false);
                //color options

                break;
            case 5:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "SHAVED SIDES";
                //meshes
                ShavedSide.SetActive(true);
                Short.SetActive(false);
                Ponytail.SetActive(false);
                //color options

                break;
            case 6:
                //text
                HairCurrent.GetComponent<TextMeshProUGUI>().text = "SHORT";
                //meshes
                Short.SetActive(true);
                ShavedSide.SetActive(false);
                //color options

                break;
        }
    }

    public void FacialHairNext()
    {
        if (FacialHairList < 2)
        {
            FacialHairList++;
        }
        //FacialHairMultipleMesh
        switch (FacialHairList)
        {
            case 0:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Beard.SetActive(false);
                //color options

                break;
            case 1:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "BEARD";
                //meshes
                Beard.SetActive(true);
                Mustache.SetActive(false);
                //color options

                break;
            case 2:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "MUSTACHE";
                //meshes
                Mustache.SetActive(true);
                Beard.SetActive(false);
                //color options

                break;
        }
    }
    public void FacialHairPrev()
    {
        if (FacialHairList > 0)
        {
            FacialHairList--;
        }
        //FacialHairMultipleMesh
        switch (FacialHairList)
        {
            case 0:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Beard.SetActive(false);
                //color options

                break;
            case 1:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "BEARD";
                //meshes
                Beard.SetActive(true);
                Mustache.SetActive(false);
                //color options

                break;
            case 2:
                //text
                FacialHairCurrent.GetComponent<TextMeshProUGUI>().text = "MUSTACHE";
                //meshes
                Mustache.SetActive(true);
                Beard.SetActive(false);
                //color options

                break;
        }
    }

    public void TopClothesNext()
    {
        if (TopClothingList < 4)
        {
            TopClothingList++;
        }
        //TopClothingMultipleMesh
        switch (TopClothingList)
        {
            case 0:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                TShirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(true);
                TopCamo.SetActive(true);
                break;
            case 1:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TSHIRT";
                //meshes
                TShirt.SetActive(true);
                TankTop.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(true);
                break;
            case 2:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TANK TOP";
                //meshes
                TankTop.SetActive(true);
                TShirt.SetActive(false);
                Shirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(false);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(false);
                break;
            case 3:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHIRT";
                //meshes
                Shirt.SetActive(true);
                TankTop.SetActive(false);
                Jacket.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(false);
                break;
            case 4:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JACKET";
                //meshes
                Jacket.SetActive(true);
                Shirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(false);
                TopRed.SetActive(true);
                TopGreen.SetActive(false);
                TopGrey.SetActive(true);
                TopPink.SetActive(false);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(true);
                TopCamo.SetActive(false);
                break;
            
        }
    }
    public void TopClothesPrev()
    {
        if (TopClothingList > 0)
        {
            TopClothingList--;
        }
        //TopCLothingMultipleMesh
        switch (TopClothingList)
        {
            case 0:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                TShirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(true);
                TopCamo.SetActive(true);
                break;
            case 1:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TSHIRT";
                //meshes
                TShirt.SetActive(true);
                TankTop.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(true);
                break;
            case 2:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TANK TOP";
                //meshes
                TankTop.SetActive(true);
                TShirt.SetActive(false);
                Shirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(false);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(false);
                break;
            case 3:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHIRT";
                //meshes
                Shirt.SetActive(true);
                TankTop.SetActive(false);
                Jacket.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(true);
                TopRed.SetActive(true);
                TopGreen.SetActive(true);
                TopGrey.SetActive(true);
                TopPink.SetActive(true);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(false);
                TopCamo.SetActive(false);
                break;
            case 4:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JACKET";
                //meshes
                Jacket.SetActive(true);
                Shirt.SetActive(false);
                //color options
                TopBlack.SetActive(true);
                TopWhite.SetActive(true);
                TopLBlue.SetActive(false);
                TopRed.SetActive(true);
                TopGreen.SetActive(false);
                TopGrey.SetActive(true);
                TopPink.SetActive(false);
                TopDBlue.SetActive(true);
                TopBrown.SetActive(true);
                TopCamo.SetActive(false);
                break;

        }
    }

    public void BottomClothesNext()
    {
        if (BottomClothingList < 3)
        {
            BottomClothingList++;
        }
        //BottomClothingMultipleMesh
        switch (BottomClothingList)
        {
            case 0:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Jeans.SetActive(false);
                //color options

                break;
            case 1:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JEANS";
                //meshes
                Jeans.SetActive(true);
                Shorts.SetActive(false);
                //color options

                break;
            case 2:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHORTS";
                //meshes
                Shorts.SetActive(true);
                Jeans.SetActive(false);
                Joggers.SetActive(false);
                //color options

                break;
            case 3:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JOGGERS";
                //meshes
                Joggers.SetActive(true);
                Shorts.SetActive(false);
                //color options

                break;
        }

    }
    public void BottomClothesPrev()
    {
        if (BottomClothingList > 0)
        {
            BottomClothingList--;
        }
        //BottomCLothingMultipleMesh
        switch (BottomClothingList)
        {
            case 0:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Jeans.SetActive(false);
                //color options

                break;
            case 1:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JEANS";
                //meshes
                Jeans.SetActive(true);
                Shorts.SetActive(false);
                //color options

                break;
            case 2:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHORTS";
                //meshes
                Shorts.SetActive(true);
                Jeans.SetActive(false);
                Joggers.SetActive(false);
                //color options

                break;
            case 3:
                //text
                BottomClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JOGGERS";
                //meshes
                Joggers.SetActive(true);
                Shorts.SetActive(false);
                //color options

                break;
        }


    }

    public void ShoesNext()
    {
        if (ShoesList < 3)
        {
            ShoesList++;
        }
        //ShoesMultipleMesh
        switch (ShoesList)
        {
            case 0:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Converse.SetActive(false);
                //color options

                break;
            case 1:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "SNEAKERS"; //Converse
                //meshes
                Converse.SetActive(true);
                DC.SetActive(false);
                //color options

                break;
            case 2:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "SKATER"; //DC
                //meshes
                DC.SetActive(true);
                Formal.SetActive(false);
                Converse.SetActive(false);
                //color options

                break;
            case 3:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "FORMAL";
                //meshes
                Formal.SetActive(true);
                DC.SetActive(false);
                //color options

                break;
        }

    }
    public void ShoesPrev()
    {
        if (ShoesList > 0)
        {
            ShoesList--;
        }
        //ShoesMultipleMesh
        switch (ShoesList)
        {
            case 0:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "NONE";
                //meshes
                Converse.SetActive(false);
                //color options

                break;
            case 1:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "SNEAKERS"; //Converse
                //meshes
                Converse.SetActive(true);
                DC.SetActive(false);
                //color options

                break;
            case 2:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "SKATER"; //DC
                //meshes
                DC.SetActive(true);
                Formal.SetActive(false);
                Converse.SetActive(false);
                //color options

                break;
            case 3:
                //text
                ShoesCurrent.GetComponent<TextMeshProUGUI>().text = "FORMAL";
                //meshes
                Formal.SetActive(true);
                DC.SetActive(false);
                //color options

                break;
        }


    }


    //TEXTURES-----------------------------

    //Skintone
    public void SkinTone1()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex1);
    }
    public void SkinTone2()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex2);
    }
    public void SkinTone3()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex3);
    }
    public void SkinTone4()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex4);
    }
    public void SkinTone5()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex5);
    }
    public void SkinTone6()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex6);
    }
    public void SkinTone7()
    {
        Body.GetComponent<Renderer>().material.SetTexture("_MainTex", SkinTex7);
    }

    //Eyecolor
    public void EyeLightBrown()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeLBrownTex);
    }
    public void EyeGreen()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeGreenTex);
    }
    public void EyeLightGreen()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeLGreenTex);
    }
    public void EyeBlue()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeBlueTex);
    }
    public void EyeLightBlue()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeLBlueTex);
    }
    public void EyeHazel()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeHazelTex);
    }
    public void EyeBrown()
    {
        Other.GetComponent<Renderer>().material.SetTexture("_MainTex", EyeBrownTex);
    }

    //Haircolor
    public void HairBlack()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT);
    }
    public void HairBrown()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT4);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT4);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT);
    }
    public void HairGreen()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT);
    }
    public void HairGrey()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT);
    }
    public void HairPink()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT);
    }
    public void HairBlonde()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT);
    }
    public void HairBlue()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT);
    }
    public void HairRed()
    {
        BackComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT2);
        Messy.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT3);
        MiddleComb.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT2);
        Ponytail.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT2);
        ShavedSide.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT2);
        Short.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT);
    }

    //FacialHairColor
    public void FacialHairBlack()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlackT3);
    }
    public void FacialHairBlonde()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlondeT3);
    }
    public void FacialHairBlue()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBlueT3);
    }
    public void FacialHairBrown()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairBrownT3);
    }
    public void FacialHairGreen()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreenT3);
    }
    public void FacialHairGrey()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairGreyT3);
    }
    public void FacialHairPink()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairPinkT3);
    }
    public void FacialHairRed()
    {
        Mustache.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT);
        Beard.GetComponent<Renderer>().material.SetTexture("_MainTex", HairRedT3);
    }

    //TopClothing
    public void TopBlackT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtBlackTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtBlackT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopBlackT);
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketBlackT);
    }
    public void TopWhiteT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtWhiteTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtWhiteT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopWhiteT);
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketWhiteT);
    }
    public void TopLBlueT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtBlueTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtLBlueT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopLBlueT);
    }
    public void TopRedT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtRedTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtRedT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopRedT);
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketRedT);
    }
    public void TopGreenT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtGreenTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtGreenT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopGreenT);
    }
    public void TopGreyT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtGreyTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtGreyT);
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketGreyT);
    }
    public void TopPinkT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtPinkTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtPinkT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopPinkT);
    }
    public void TopDBlueT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtDBlueTex);
        Shirt.GetComponent<Renderer>().material.SetTexture("_MainTex", ShirtDBlueT);
        TankTop.GetComponent<Renderer>().material.SetTexture("_MainTex", TanktopDBlueT);
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketDBlueT);
    }
    public void TopBrownT()
    {
        Jacket.GetComponent<Renderer>().material.SetTexture("_MainTex", JacketBrownT);
    }
    public void TopCamoT()
    {
        TShirt.GetComponent<Renderer>().material.SetTexture("_MainTex", TShirtCamoTex);
    }
}
