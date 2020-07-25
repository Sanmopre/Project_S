using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    private GameObject obj;
    private Score_Manager manager;

    public GameObject d;
    public GameObject c;
    public GameObject b;
    public GameObject a;
    public GameObject s;
    public GameObject ss;
    public GameObject sss;
    void Start()
    {
        obj = GameObject.Find("Score_system");
        manager = obj.GetComponent<Score_Manager>();
    }

    // Update is called once per frame
    void Update()
    {



        if (manager.in_d)
        {
            d.SetActive(true);
        }
        else {
            d.SetActive(false);
        }




        if (manager.in_b)
        {
            b.SetActive(true);
        }
        else
        {
            b.SetActive(false);
        }




        if (manager.in_c)
        {
            c.SetActive(true);
        }
        else
        {
            c.SetActive(false);
        }




        if (manager.in_a)
        {
            a.SetActive(true);
        }
        else
        {
            a.SetActive(false);
        }




        if (manager.in_s)
        {
            s.SetActive(true);
        }
        else
        {
            s.SetActive(false);
        }




        if (manager.in_ss)
        {
            ss.SetActive(true);
        }
        else
        {
            ss.SetActive(false);
        }




        if (manager.in_sss)
        {
            sss.SetActive(true);
        }
        else
        {
            sss.SetActive(false);
        }










    }




}
