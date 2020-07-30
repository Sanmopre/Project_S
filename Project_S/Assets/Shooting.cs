using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint_2;
    public Transform firePoint_3;

    public PlayerMovement mov;
    private float cd_cast = 0;

    private float fire_rate;
    private float fire_counter = 0;
    private int int_fire_counter = 0;

    public float first_fr;
    public float second_fr;
    public float third_fr;


    public int heat_count = 0;
    public int max_heat = 250;


    public GameObject bulletPrefab;
    public GameObject missilePrefab;

    public Overheat_Slider heat;

    private bool shooting = false;

    public enum Weapon_Type 
    { 
        W_1,
        W_2,
        W_3,
        NONE
    }

    public Weapon_Type w_type = Weapon_Type.W_2;

    public float bulletForce = 20f;



    private void Start()
    {
        heat.Set_Max_heat(max_heat);
        fire_rate = second_fr;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            heat_count = 0;

            if (w_type == Weapon_Type.W_2)
            {
                w_type = Weapon_Type.W_1;
                fire_rate = first_fr;
            }
            else if (w_type == Weapon_Type.W_3)
            {
                w_type = Weapon_Type.W_2;
                fire_rate = second_fr;
            }
            else if (w_type == Weapon_Type.W_1)
            {
                w_type = Weapon_Type.W_3;
                fire_rate = third_fr;
            }

    

        }



    


            if (Input.GetButtonDown("Fire1")  && cd_cast >= fire_rate)
        {
            shooting = true;
            cd_cast = 0;
        }

        if (Input.GetButtonUp("Fire1")) 
        {
            shooting = false;
        }

        if (shooting == true && fire_counter >= fire_rate && mov.sprinting == false && heat_count < max_heat) 
        {

                Shoot(w_type);
            if (w_type == Weapon_Type.W_2) {
                heat_count = heat_count + 1;
            }

            if (w_type == Weapon_Type.W_1)
            {
                heat_count = heat_count + 4;
            }

            if (w_type == Weapon_Type.W_3)
            {
                heat_count = heat_count + 20;
            }           
            fire_counter = 0;
        }

        fire_counter = fire_counter + Time.deltaTime;
        cd_cast = cd_cast + Time.deltaTime;
        if (shooting == false)
        {
            fire_counter = fire_rate;
        }

        heat.Set_heat(heat_count);
    }




    void Shoot(Weapon_Type weapon_t) {

        switch (weapon_t)
        {

        case Weapon_Type.W_1:         GameObject bullet_1 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
         GameObject bullet_2 = Instantiate(bulletPrefab, firePoint_2.position, firePoint_2.rotation);
                GameObject bullet_3 = Instantiate(bulletPrefab, firePoint_3.position, firePoint_3.rotation);

                Rigidbody2D rb_1 = bullet_1.GetComponent<Rigidbody2D>();
                rb_1.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                Rigidbody2D rb_2 = bullet_2.GetComponent<Rigidbody2D>();
                rb_2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                Rigidbody2D rb_3 = bullet_3.GetComponent<Rigidbody2D>();
                rb_3.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);




        break;


        case Weapon_Type.W_2:
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                
          break;


        case Weapon_Type.W_3:
                GameObject missile = Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb_m = missile.GetComponent<Rigidbody2D>();
                rb_m.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                break;
        }
    }



}
