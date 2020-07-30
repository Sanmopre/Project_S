using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_pack_collision : MonoBehaviour
{
    public int Energy_pack = 150;
    private GameObject spawner;

    private void Start()
    {
        spawner = GameObject.Find("Object_spawner");

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerMovement player_c = collider.GetComponent<PlayerMovement>();

        if (player_c != null)
        {
            player_c.stamina = player_c.stamina + Energy_pack;
            Destroy(gameObject);
        }

    }
}
