using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public int damage;

    private void OnCollisionEnter2D(Collision2D hitinfo)
    {

        Health enemy = hitinfo.otherCollider.GetComponent<Health>();

        if (enemy != null) {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);

    }

}
