using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities_manager : MonoBehaviour
{
    public TrailRenderer trail;
    public Sprite Ultimate_Sprite;
    public Sprite Normal_Sprite;
    public Sprite Dead_Sprite;
    public PlayerMovement mov;
    private int trail_delay = 10;
    private int counter = 10;

    public Player_Health health;

    private GameObject obj;
    private Score_Manager score;


    public int blade_damage;
    public int blade_score = 5;

    public float blade_counter = 0;

    public CircleCollider2D saw_collider;


    private void Start()
    {
        obj = GameObject.Find("Score_system");
        score = obj.GetComponent<Score_Manager>();


    }


    void Update()
    {



        if (!health.dead)
        {
            if (mov.sprinting)
            {
                saw_collider.enabled = true;
                trail.enabled = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Ultimate_Sprite;
                counter = 15;
            }
            else
            {
                saw_collider.enabled = false;
                if (counter < 0)
                {
                    trail.enabled = false;
                }
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal_Sprite;


                blade_counter = 0;
            }
            counter--;
        }
        else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Dead_Sprite;
        }
        }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null && mov.sprinting)
        {
            enemy.TakeDamage(blade_damage);
            blade_counter = blade_counter + 0.5f;
            score.score = score.score + blade_score;
        }


    }

}
