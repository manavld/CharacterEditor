using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        
    }

    public void OnRandomize100()
    {
        Ectomorph.value = Random.Range(0, 100);
        Endomorph.value = Random.Range(0, 100);
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
    }

    public void OnRandomize200()
    {
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
    }
}
