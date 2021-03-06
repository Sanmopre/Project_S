﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemy_shooter;
    public GameObject exploding_enemy;

    private GameObject player;
    private Transform trans;

    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawn_rate = 2f;
    public float spawn_rate_shooter = 2f;
    public float spawn_rate_exploding = 2f;
    public float increase_rate;

    public float max_spawn;
    public float max_spawn_shooter;
    public float max_spawn_exploding;

    public int distance_x;
    public int distance_y;

    float nextSpawn = 0.0f;
    float nextSpawn_s = 0.0f;
    float nextSpawn_e = 0.0f;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Character");
        trans = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {

            nextSpawn = Time.time + spawn_rate;
            randX = Random.Range(-20,20);
            randY = Random.Range(2, -35);

            if (randX < trans.position.x - distance_x || randX > trans.position.x + distance_x && randY < trans.position.y - distance_y || randY > trans.position.y + distance_y)
            {
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }

        }


        if (Time.time > nextSpawn_s)
        {
            nextSpawn_s = Time.time + spawn_rate_shooter;
            randX = Random.Range(-20, 20);
            randY = Random.Range(2, -35);
            if (randX < trans.position.x - distance_x || randX > trans.position.x + distance_x && randY < trans.position.y - distance_y || randY > trans.position.y + distance_y)
            {
                whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy_shooter, whereToSpawn, Quaternion.identity);
            }
        }

        if (Time.time > nextSpawn_e)
        {
            nextSpawn_e = Time.time + spawn_rate_exploding;
            randX = Random.Range(-20, 20);
            randY = Random.Range(2, -35);
            if (randX < trans.position.x - distance_x || randX > trans.position.x + distance_x && randY < trans.position.y - distance_y || randY > trans.position.y + distance_y)
            {
                whereToSpawn = new Vector2(randX, randY);
                Instantiate(exploding_enemy, whereToSpawn, Quaternion.identity);
            }
        }

        if (spawn_rate < max_spawn) {
            spawn_rate = max_spawn;
        }

        if (spawn_rate_shooter < max_spawn_shooter)
        {
            spawn_rate_shooter = max_spawn_shooter;
        }

        if (spawn_rate_exploding < max_spawn_exploding)
        {
            spawn_rate_exploding = max_spawn_exploding;
        }

        spawn_rate = spawn_rate - increase_rate;
        spawn_rate_shooter = spawn_rate_shooter - increase_rate;
        spawn_rate_exploding = spawn_rate_exploding - increase_rate;
    }
}
