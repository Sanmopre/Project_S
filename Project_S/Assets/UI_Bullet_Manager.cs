using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Bullet_Manager : MonoBehaviour
{

    public GameObject weapon_1;
    public GameObject weapon_2;

    private GameObject player;
    private Shooting shoot;

    void Start()
    {
        player = GameObject.Find("Character");
        shoot = player.GetComponent<Shooting>();
    }

    void Update()
    {
        if (shoot.w_type == Shooting.Weapon_Type.W_1)
        {
            weapon_1.SetActive(true);
            weapon_2.SetActive(false);
        }
        else if (shoot.w_type == Shooting.Weapon_Type.W_2) {
            weapon_2.SetActive(true);
            weapon_1.SetActive(false);
        }
    }
}
