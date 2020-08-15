using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public int Max_hp;
    public int hp;
    private bool poisoned = false;
    private int poison_damage = 0;
    private int poison_time = 0;
    public HealthBar hp_bar;

    public bool dead = false;
    float death_timer = 0;
    public float death_timer_max;
    public Image black;
    public GameObject fade_obj;

    private GameObject x;
    private Score_Manager score;



    private void Start()
    {
        hp_bar.Set_Max_health(Max_hp);

        x = GameObject.Find("Score_system");
        score = x.GetComponent<Score_Manager>();
    }


    void Update()
    {
       
        //POISON MANAGER
        if(poisoned == true)
        {
            if( poison_time % 3 == 0) {
                Take_Damage(poison_damage);
            }
            poison_time--;
        }

        if (poison_time <= 0) {
            poison_time = 0;
            poisoned = false;
        }


        hp_bar.Set_health(hp);


        if (hp <= 0) {
            dead = true;
        }


        if (dead) {
            fade_obj.SetActive(true);
            death_timer = death_timer + Time.deltaTime;
            black.color = new Color(0, 0, 0, death_timer/ death_timer_max);
            if (death_timer > death_timer_max) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }


        if (Max_hp < hp) {
            hp = Max_hp;
        }

    }


    public void Take_Damage(int damage) {
        hp = hp - damage;

        score.score = score.score - 50 - score.score/3;
    }

    public void Poison(int time, int damage) {
        poisoned = true;
        poison_damage = damage;

    }
}

