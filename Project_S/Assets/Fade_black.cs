using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_black : MonoBehaviour
{

    public GameObject fade_obj;
    public Image black;

    float counter = 1;
    float in_counter = 0;

    public bool in_finished;

    public float rate;
    bool finished = false;


    

    void Update()
    {
        if (!finished) {

            if (counter > 0)
            {
                black.color = new Color(0, 0, 0, counter);

                counter = counter - rate * Time.deltaTime;
            }
            else {
                finished = true;
                fade_obj.SetActive(false);
            }

        }
    }


    public void Fade_In() {
        fade_obj.SetActive(true);
        if (!in_finished)
        {

            if (in_counter < 1)
            {
                black.color = new Color(0, 0, 0, in_counter);

                in_counter = in_counter + rate * Time.deltaTime;
            }
            else
            {
                in_finished = true;
            }

        }

    }
}
