using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public int damage;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null) {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
