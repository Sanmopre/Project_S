using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_pack_collision : MonoBehaviour
{
    public int HP_pack= 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Player_Health player_c = collider.GetComponent<Player_Health>();

        if (player_c != null)
        {
            player_c.hp = player_c.hp + HP_pack;
            Destroy(gameObject);
        }

    }
}
