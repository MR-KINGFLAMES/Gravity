using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Bar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxO2(int O2)
    {
        slider.value = O2;
        slider.maxValue = O2;

       fill.color = gradient.Evaluate(1f);
    }

    public void SetO2(int O2)
    {
        slider.value = O2;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
