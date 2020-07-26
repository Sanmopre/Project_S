using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Overheat_Slider : MonoBehaviour
{
    public Slider slider;

    public void Set_heat(int heat)
    {
        slider.value = heat;
    }

    public void Set_Max_heat(int heat)
    {
        slider.maxValue = heat;
        slider.value = heat;
    }
}
