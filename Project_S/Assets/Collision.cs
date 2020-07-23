using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public int damage;
    public int hit_count;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            hit_count = 1;
        }
        else {
            hit_count = 0;
        }

        Destroy(gameObject);
    }
}
