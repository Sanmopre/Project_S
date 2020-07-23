using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public float score = 0f;
    public int score_time;
    private int counter = 0;
    public Collision hit;
    public Player_Health health;


    // Update is called once per frame
    void Update()
    {
        
        score = score + hit.hit_count * 1.5f;

        if (health.damaged == true) {
            score = score - 50;
        }

        score--;
    }
}
