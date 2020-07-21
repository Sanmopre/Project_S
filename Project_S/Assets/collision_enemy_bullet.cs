using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_enemy_bullet : MonoBehaviour
{

    public int damage;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Player_Health player = collider.GetComponent<Player_Health>();

        if (player != null)
        {
            player.Take_Damage(damage);
        }

        Destroy(gameObject);
    }
}
