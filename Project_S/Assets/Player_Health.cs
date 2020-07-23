using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{

    public int hp;
    private bool poisoned = false;
    private int poison_damage = 0;
    private int poison_time = 0;
    public bool damaged = true;
    public HealthBar hp_bar;




    private void Start()
    {
        hp_bar.Set_Max_health(hp);
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
        damaged = false;
    }


    public void Take_Damage(int damage) {
        damaged = true;
        hp = hp - damage;
    }

    public void Poison(int time, int damage) {
        poisoned = true;
        poison_damage = damage;

    }
}
