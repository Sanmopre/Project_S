using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_player : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Player_Health player = collider.GetComponent<Player_Health>();

        if (player != null)
        {
            player.Take_Damage(damage);
        }

    }
}
