using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Set_target : MonoBehaviour
{
    private GameObject player;

    public AIDestinationSetter character;
    void Start()
    {
        player = GameObject.Find("Character");
        character.target = player.transform;
    }

}
