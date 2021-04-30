using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{
    private TextMeshProUGUI Value_Update;
    private Slider parent_value;

    private void Start()
    {
        //parent_value = Value_Update.GetComponentInParent<Slider>().value;
        Value_Update = GetComponent<TextMeshProUGUI>();
        Value_Update.text = (Mathf.Round(Value_Update.GetComponentInParent<Slider>().value * 100.0f) / 100.0f).ToString();
    }

    public void SliderValueUpdate(float value)
    {
        //Value_Update.text = (Mathf.Round(value * 100.0f)/100.0f).ToString();
     
    }
}
