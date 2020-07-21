using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void Set_health(int health)
    {
        slider.value = health;
    }

    public void Set_Max_health(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
}
