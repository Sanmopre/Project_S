using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Using_blade_ui_controller : MonoBehaviour
{
    public Image image;
    public PlayerMovement mov;

    // Update is called once per frame
    void Update()
    {
        if (mov.sprinting)
        {
            image.enabled = true;
        }
        else {
            image.enabled = false;
        }
    }
}
