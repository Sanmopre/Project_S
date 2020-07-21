﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawn_rate = 2f;
    float nextSpawn = 0.0f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawn_rate;
            randX = Random.Range(-20,20);
            randY = Random.Range(2, -35);

            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);

        }
    }
}