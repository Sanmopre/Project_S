using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Explosion : MonoBehaviour
{

    public int aoe_damage;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {

            enemy.TakeDamage(aoe_damage);
        }
        Destroy(gameObject);
    }
}
