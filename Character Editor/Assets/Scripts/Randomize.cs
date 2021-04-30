using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Randomize : MonoBehaviour
{
    public Slider Ectomorph, Endomorph, HeadOval, HeadRound, HeadSquare, NosePStraightF, NosePRoundF, NosePStraightP, NosePRoundP, NosePWidth, NoseBump, ChinSquare, ChinRound, ChinPointy, EyesRound, EyesAlmond;
    public Slider ForeheadSize, ForeheadWidth, CheekbonesPos, NoseBWide, NoseBLength, NostrilsSize, NosePPos, EarSize, EarLobes, EarDistance, ChinPromin, ChinPos, MouthWidth, LipUSize, LipLSize, EyesPos, EyesSize;
    // Start is called before the first frame update
    void Start()
    {

    }  

    // Update is called once per frame
    void Update()
    {
            Ectomorph.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(Ectomorph.value * 100.0f) / 100.0f).ToString();
            Endomorph.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(Endomorph.value * 100.0f) / 100.0f).ToString();
            HeadOval.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(HeadOval.value * 100.0f) / 100.0f).ToString();
            HeadRound.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(HeadRound.value * 100.0f) / 100.0f).ToString();
            HeadSquare.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(HeadSquare.value * 100.0f) / 100.0f).ToString();
            NosePStraightF.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePStraightF.value * 100.0f) / 100.0f).ToString();
            NosePRoundF.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePRoundF.value * 100.0f) / 100.0f).ToString();
            NosePStraightP.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePStraightP.value * 100.0f) / 100.0f).ToString();
            NosePRoundP.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePRoundP.value * 100.0f) / 100.0f).ToString();
            NosePWidth.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePWidth.value * 100.0f) / 100.0f).ToString();
            NoseBump.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NoseBump.value * 100.0f) / 100.0f).ToString();
            ChinSquare.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ChinSquare.value * 100.0f) / 100.0f).ToString();
            ChinRound.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ChinRound.value * 100.0f) / 100.0f).ToString();
            ChinPointy.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ChinPointy.value * 100.0f) / 100.0f).ToString();
            EyesRound.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EyesRound.value * 100.0f) / 100.0f).ToString();
            EyesAlmond.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(Ectomorph.value * 100.0f) / 100.0f).ToString();
            //200
            ForeheadSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ForeheadSize.value * 100.0f) / 100.0f).ToString();
            ForeheadWidth.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ForeheadWidth.value * 100.0f) / 100.0f).ToString();
            CheekbonesPos.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(CheekbonesPos.value * 100.0f) / 100.0f).ToString();
            NoseBWide.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NoseBWide.value * 100.0f) / 100.0f).ToString();
            NoseBLength.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NoseBLength.value * 100.0f) / 100.0f).ToString();
            NostrilsSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NostrilsSize.value * 100.0f) / 100.0f).ToString();
            NosePPos.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(NosePPos.value * 100.0f) / 100.0f).ToString();
            EarSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EarSize.value * 100.0f) / 100.0f).ToString();
            EarLobes.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EarLobes.value * 100.0f) / 100.0f).ToString();
            EarDistance.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EarDistance.value * 100.0f) / 100.0f).ToString();
            ChinPromin.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ChinPromin.value * 100.0f) / 100.0f).ToString();
            ChinPos.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(ChinPos.value * 100.0f) / 100.0f).ToString();
            MouthWidth.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(MouthWidth.value * 100.0f) / 100.0f).ToString();
            LipUSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(LipUSize.value * 100.0f) / 100.0f).ToString();
            LipLSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(LipLSize.value * 100.0f) / 100.0f).ToString();
            EyesPos.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EyesPos.value * 100.0f) / 100.0f).ToString();
            EyesSize.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = (Mathf.Round(EyesSize.value * 100.0f) / 100.0f).ToString();
        
    }

    public void OnRandomize()
    {
        //activate
        FeaturesSelection.BodyWindow.gameObject.SetActive(true);
        FeaturesSelection.HeadWindow.gameObject.SetActive(true);
        FeaturesSelection.NoseWindow.gameObject.SetActive(true);
        FeaturesSelection.EarWindow.gameObject.SetActive(true);
        FeaturesSelection.ChinWindow.gameObject.SetActive(true);
        FeaturesSelection.MouthWindow.gameObject.SetActive(true);
        FeaturesSelection.EyesWindow.gameObject.SetActive(true);

        
        HeadOval.value = Random.Range(0, 100);
        HeadRound.value = Random.Range(0, 100);
        HeadSquare.value = Random.Range(0, 100);
        NosePStraightF.value = Random.Range(0, 100);
        NosePRoundF.value = Random.Range(0, 100);
        NosePStraightP.value = Random.Range(0, 100);
        NosePRoundP.value = Random.Range(0, 100);
        NosePWidth.value = Random.Range(0, 100);
        NoseBump.value = Random.Range(0, 100);
        ChinSquare.value = Random.Range(0, 100);
        ChinRound.value = Random.Range(0, 100);
        ChinPointy.value = Random.Range(0, 100);
        EyesRound.value = Random.Range(0, 100);
        EyesAlmond.value = Random.Range(0, 100);
        //200
        Ectomorph.value = Random.Range(-100, 100);
        Endomorph.value = Random.Range(-100, 100);
        ForeheadSize.value = Random.Range(-100, 100);
        ForeheadWidth.value = Random.Range(-100, 100);
        CheekbonesPos.value = Random.Range(-100, 100);
        NoseBWide.value = Random.Range(-100, 100);
        NoseBLength.value = Random.Range(-100, 100);
        NostrilsSize.value = Random.Range(-100, 100);
        NosePPos.value = Random.Range(-100, 100);
        EarSize.value = Random.Range(-100, 100);
        EarLobes.value = Random.Range(-100, 100);
        EarDistance.value = Random.Range(-100, 100);
        ChinPromin.value = Random.Range(-100, 100);
        ChinPos.value = Random.Range(-100, 100);
        MouthWidth.value = Random.Range(-100, 100);
        LipUSize.value = Random.Range(-100, 100);
        LipLSize.value = Random.Range(-100, 100);
        EyesPos.value = Random.Range(-100, 100);
        EyesSize.value = Random.Range(-100, 100);

        //deactivate
        FeaturesSelection.BodyWindow.gameObject.SetActive(false);
        FeaturesSelection.HeadWindow.gameObject.SetActive(false);
        FeaturesSelection.NoseWindow.gameObject.SetActive(false);
        FeaturesSelection.EarWindow.gameObject.SetActive(false);
        FeaturesSelection.ChinWindow.gameObject.SetActive(false);
        FeaturesSelection.MouthWindow.gameObject.SetActive(false);
        FeaturesSelection.EyesWindow.gameObject.SetActive(false);
    }

}
