using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_player : MonoBehaviour
{
    public Player_Health player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {
            player.Take_Damage(20);
        }

    }
}
