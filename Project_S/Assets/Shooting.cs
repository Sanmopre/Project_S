using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint_2;
    public Transform firePoint_3;

    public PlayerMovement mov;
    private int cd_cast = 0;

    public int fire_rate = 3;
    private int fire_counter = 0;

    public GameObject bulletPrefab;
    public GameObject missilePrefab;

    private bool shooting = false;

    public enum Weapon_Type 
    { 
        W_1,
        W_2,
        W_3,
        NONE
    }

    public Weapon_Type w_type = Weapon_Type.W_1;

    public float bulletForce = 20f;



    private void Start()
    {
        fire_rate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {



            if (w_type == Weapon_Type.W_2)
            {
                w_type = Weapon_Type.W_1;
                fire_rate = 10;
            }
            else if (w_type == Weapon_Type.W_3)
            {
                w_type = Weapon_Type.W_2;
                fire_rate = 3;
            }
            else if (w_type == Weapon_Type.W_1)
            {
                w_type = Weapon_Type.W_3;
                fire_rate = 20;
            }

    

        }





        if (Input.GetButtonDown("Fire1")  && cd_cast > fire_rate)
        {
            shooting = true;
            cd_cast = 0;
        }

        if (Input.GetButtonUp("Fire1")) 
        {
            shooting = false;
        }

        if (shooting == true && fire_counter % fire_rate == 0 && mov.sprinting == false) 
        {
            Shoot(w_type);

        }


        fire_counter++;
        cd_cast++;
        if (shooting == false)
        {
            fire_counter = 0;
        }
        
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
