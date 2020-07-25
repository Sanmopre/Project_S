using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Explosion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {

            enemy.TakeDamage(1000);
        }
        Destroy(gameObject);
    }
}
