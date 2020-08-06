using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overheat_Screen_Controller : MonoBehaviour
{

    public Image screen;
    private float overheat = 0;
    public Shooting shoot;
    public GameObject max_heat;

    // Update is called once per frame
    void Update()
    {

        screen.color = new Color(255,255,255, shoot.heat_count / shoot.max_heat);

        if (shoot.heat_count >= shoot.max_heat)
        {
            max_heat.SetActive(true);
        }
        else {
            max_heat.SetActive(false);
        }
    }

}
