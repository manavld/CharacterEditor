using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultipleMeshMale : MonoBehaviour
{
    //Parents
    public GameObject Clothing, Hair, HairWindow, EyeWindow, SkinWindow, TopWindow, BottomWindow, ShoesWindow;
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

    //BottomClothing Window
    private GameObject BottomClothesCurrent;

    //Shoes Window
    private GameObject ShoesCurrent;

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
    }

    // Update is called once per frame
    void Update()
    {

       
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

                break;
            case 1:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TSHIRT";
                //meshes
                TShirt.SetActive(true);
                TankTop.SetActive(false);
                //color options

                break;
            case 2:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TANK TOP";
                //meshes
                TankTop.SetActive(true);
                TShirt.SetActive(false);
                Shirt.SetActive(false);
                //color options

                break;
            case 3:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHIRT";
                //meshes
                Shirt.SetActive(true);
                TankTop.SetActive(false);
                Jacket.SetActive(false);
                //color options

                break;
            case 4:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JACKET";
                //meshes
                Jacket.SetActive(true);
                Shirt.SetActive(false);
                //color options

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

                break;
            case 1:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TSHIRT";
                //meshes
                TShirt.SetActive(true);
                TankTop.SetActive(false);
                //color options

                break;
            case 2:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "TANK TOP";
                //meshes
                TankTop.SetActive(true);
                TShirt.SetActive(false);
                Shirt.SetActive(false);
                //color options

                break;
            case 3:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "SHIRT";
                //meshes
                Shirt.SetActive(true);
                TankTop.SetActive(false);
                Jacket.SetActive(false);
                //color options

                break;
            case 4:
                //text
                TopClothesCurrent.GetComponent<TextMeshProUGUI>().text = "JACKET";
                //meshes
                Jacket.SetActive(true);
                Shirt.SetActive(false);
                //color options

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




}
