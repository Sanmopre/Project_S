using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting : MonoBehaviour
{


    private int time = 0;
    public int firerate;
    public int bulletForce;
    public GameObject bullet;
    public Transform position;


    private int shoot_counter;

    public int range;
    public Transform target;

    public Transform enemy;

    private bool in_range = true;

    // Update is called once per frame
    void Update()
    {

         

        if (Mathf.Abs(target.position.x - this.transform.position.x)  < range && Mathf.Abs(target.position.y - this.transform.position.y) < range) {
            in_range = true;
        }
        else
        {
            in_range = false;
        }

            
        if (in_range && shoot_counter % firerate == 0)
        {
            Shoot();
        }

        shoot_counter++;
    }

    void Shoot() {

        GameObject bullet_p = Instantiate(bullet, position.position, position.rotation);
        Rigidbody2D rb = bullet_p.GetComponent<Rigidbody2D>();
      
        rb.AddForce(position.up * bulletForce, ForceMode2D.Impulse);
    }
}
