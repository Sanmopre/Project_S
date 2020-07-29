using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities_slider : MonoBehaviour
{
    public Slider slider;

    public void Set_Ability_cd(float cd)
    {
        slider.value = cd;
    }

    public void Set_Max_Ability_cd(float cd)
    {
        slider.maxValue = cd;
        slider.value = cd;
    }
}
