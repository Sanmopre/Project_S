using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject health;
    public GameObject energy;

    float randX;
    float randY;

    public Vector2 pos_1;
    public Vector2 pos_2;
    public Vector2 pos_3;
    public Vector2 pos_4;


    public float spawn_rate_h = 2f;
    public float spawn_rate_e = 2f;

    float nextSpawn_h = 0.0f;
    float nextSpawn_e = 0.0f;
    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn_h)
        {

            nextSpawn_h = Time.time + spawn_rate_h;
            randX = Random.Range(-20, 20);
            randY = Random.Range(2, -35);

            pos_1 = new Vector2(randX, randY);
            Instantiate(health, pos_1, Quaternion.identity);
        }

        if (Time.time > nextSpawn_e)
        {

            nextSpawn_e = Time.time + spawn_rate_e;
            randX = Random.Range(-20, 20);
            randY = Random.Range(2, -35);

            pos_1 = new Vector2(randX, randY);
            Instantiate(energy, pos_1, Quaternion.identity);
        }

    }
}
