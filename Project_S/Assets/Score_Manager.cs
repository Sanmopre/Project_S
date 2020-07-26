using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public int score = 0;
    public int score_time;
    private int counter = 0;

    public int d = 100;
    public int c = 200;
    public int b = 350;
    public int a = 500;
    public int s = 800;
    public int ss = 1200;
    public int sss = 1750;


    public bool in_d = false;
    public bool in_c = false;
    public bool in_b = false;
    public bool in_a = false;
    public bool in_s = false;
    public bool in_ss = false;
    public bool in_sss = false;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (score < 0) { score = 0; }
        if (score > sss + 10) { score = sss + 10; }



        if (score < d) {
    in_d = false;
    in_c = false;
    in_b = false;
    in_a = false;
    in_s = false;
    in_ss = false;
    in_sss = false;
}

        if (score > d && score < c) {
            in_d = true;
            in_c = false;
            in_b = false;
            in_a = false;
            in_s = false;
            in_ss = false;
            in_sss = false;
        }

        if (score > c && score < b) {
            in_d = false;
            in_c = true;
            in_b = false;
            in_a = false;
            in_s = false;
            in_ss = false;
            in_sss = false;
        }

        if (score > b && score < a) {
            in_d = false;
            in_c = false;
            in_b = true;
            in_a = false;
            in_s = false;
            in_ss = false;
            in_sss = false;
        }

        if (score > a && score < s) {
            in_d = false;
            in_c = false;
            in_b = false;
            in_a = true;
            in_s = false;
            in_ss = false;
            in_sss = false;
        }

        if (score > s && score < ss) {
            in_d = false;
            in_c = false;
            in_b = false;
            in_a = false;
            in_s = true;
            in_ss = false;
            in_sss = false;
        }

        if (score > ss && score < sss) {
            in_d = false;
            in_c = false;
            in_b = false;
            in_a = false;
            in_s = false;
            in_ss = true;
            in_sss = false;
        }

        if (score > sss) {
            in_d = false;
            in_c = false;
            in_b = false;
            in_a = false;
            in_s = false;
            in_ss = false;
            in_sss = true;
        }
    }
}
