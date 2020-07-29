using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting : MonoBehaviour
{


    private int time = 0;
    public float firerate;
    public int bulletForce;
    public GameObject bullet;
    public Transform position;

    private GameObject player;
    private Transform target;

    private float shoot_counter;

    public int range;

    public Transform enemy;

    private bool in_range = true;


    private void Start()
    {
        player = GameObject.Find("Character");
        target = player.transform;
    }

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

            
        if (in_range && shoot_counter >= firerate)
        {
            Shoot();
            shoot_counter = 0;
        }

        shoot_counter = shoot_counter + Time.deltaTime;
    }

    void Shoot() {

        GameObject bullet_p = Instantiate(bullet, position.position, position.rotation);
        Rigidbody2D rb = bullet_p.GetComponent<Rigidbody2D>();
      
        rb.AddForce(position.up * bulletForce, ForceMode2D.Impulse);
    }
}
