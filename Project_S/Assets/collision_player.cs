using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_player : MonoBehaviour
{
    public Player_Health player;
    public PlayerMovement mov;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {
            if(mov.sprinting == false)
            player.Take_Damage(20);
        }

    }
}
