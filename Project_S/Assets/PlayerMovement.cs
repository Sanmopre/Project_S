using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
   
    public Rigidbody2D rb;
    public Camera cam;

    public float sprint = 1.5f;
    public int stamina = 500;
    public int max_stamina = 500;

    public int sprint_cooldown;
    private int cd_sprint = 100;

    public bool sprinting = false;

    private int direction;

    Vector2 movement;
    Vector2 mousePos;

    public StaminaBar stamina_bar;

    private void Start()
    {
        stamina_bar.Set_Max_Stamina(stamina);
    }

    // Update is called once per frame
    void Update()
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
            stamina = stamina - 2;
        }
        else {
            if(stamina < max_stamina)
            stamina++;
            cd_sprint++;
        }



           
 


        if (stamina <= 0) {
            sprinting = false;
        }


        stamina_bar.Set_Stamina(stamina);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
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


        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
