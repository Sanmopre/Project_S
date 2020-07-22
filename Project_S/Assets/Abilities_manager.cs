using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities_manager : MonoBehaviour
{
    public TrailRenderer trail;
    public Sprite Ultimate_Sprite;
    public Sprite Normal_Sprite;
    public bool in_ultimate = false;
    public PlayerMovement mov;
    private int trail_delay = 10;
    private int counter = 10;

    public int blade_damage;

    public CircleCollider2D saw_collider;

    void Update()
    {

        

        if (mov.sprinting)
        {
            saw_collider.enabled = true;
            trail.enabled = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ultimate_Sprite;
            counter = 15;
        }
        else {
            saw_collider.enabled = false;
            if (counter < 0)
            {
                trail.enabled = false;
            }
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal_Sprite;
        }
        counter--;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null && mov.sprinting)
        {
            enemy.TakeDamage(blade_damage);
        }


    }

}
