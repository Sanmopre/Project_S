using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
   
    public Rigidbody2D rb;
    public Camera cam;

    private bool can_activate_boost = true;

    public float sprint = 1.5f;
    public float stamina = 200;
    private float first_point;
    private float second_point;

    public int max_stamina = 200;

    public float sprint_cooldown;
    private float cd_sprint = 15;
    public int rotation_speed;
    public Abilities_slider ab;
    public bool sprinting = false;

    private int direction;

    public Player_Health health;

    Vector2 movement;
    Vector2 mousePos;

    public StaminaBar stamina_bar;

    private void Start()
    {
        stamina_bar.Set_Max_Stamina(stamina);
        ab.Set_Max_Ability_cd(sprint_cooldown);

        first_point = (stamina * 30) / 100;
        second_point = (stamina * 42) / 100;

    }

    // Update is called once per frame
    void Update()
    {
        if (!health.dead)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            if (Input.GetButtonDown("Sprint") && cd_sprint >= sprint_cooldown)
            {
                sprinting = true;
                cd_sprint = 0;
            }

            if (Input.GetButtonUp("Sprint"))
            {
                sprinting = false;
            }

            if (sprinting == true)
            {
                stamina = stamina - Time.deltaTime * 5;
            }
            else
            {
                if (stamina < max_stamina)
                    stamina = stamina + Time.deltaTime * 3;
                cd_sprint = cd_sprint + Time.deltaTime;
            }







            if (stamina <= 0)
            {
                sprinting = false;
            }

            if (sprinting)
            {

                if (Input.GetButtonDown("Fire1") && can_activate_boost)
                {

                    if (first_point < stamina && second_point > stamina)
                    {
                        stamina = stamina + 4;
                        can_activate_boost = false;
                    }
                    else
                    {
                        health.Take_Damage(30);
                    }

                }

            }


            if (!sprinting) { can_activate_boost = true; }

            if (stamina > max_stamina) { stamina = max_stamina; }

            stamina_bar.Set_Stamina(stamina);
            ab.Set_Ability_cd(cd_sprint);
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        }

    void FixedUpdate()
    {

        if (sprinting == false)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime * sprint);
        }

        if (sprinting == false)
        {
            Vector2 lookDir = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
        else {
            rb.rotation = rb.rotation + rotation_speed;
        }
    }
}
