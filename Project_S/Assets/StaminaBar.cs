using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StaminaBar : MonoBehaviour
{

    public Slider slider;

    public void Set_Stamina(float stamina) 
    {
        slider.value = stamina;
    }

    public void Set_Max_Stamina(float stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }

}
