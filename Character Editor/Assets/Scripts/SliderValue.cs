using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{
     private TextMeshProUGUI Value_Update;

    private void Start()
    {
        Value_Update = GetComponent<TextMeshProUGUI>();
    }

    public void SliderValueUpdate(float value)
    {
        Value_Update.text = (Mathf.Round(value * 100.0f)/100.0f).ToString();
     
    }
}
