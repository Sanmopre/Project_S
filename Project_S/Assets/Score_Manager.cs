using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public int score = 0;
    public int score_time;
    private int counter = 0;
    public GameObject bullet;

    private GameObject player;
    private Player_Health health;


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
        player = GameObject.Find("Character");
        health = player.GetComponent<Player_Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.damaged) {
            score = score - 100;
        }
        Debug.Log(score);
    }
}
