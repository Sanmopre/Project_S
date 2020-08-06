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

    private Vector2 position;
    int count_health = 1;
    int count_energy = 1;

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

            if (count_health % 2 == 0)
            {
                position = pos_1;
            }
            else {
                position = pos_3;
            }
            Instantiate(health, position, Quaternion.identity);
            count_health++;
        }

        if (Time.time > nextSpawn_e)
        {

            nextSpawn_e = Time.time + spawn_rate_e;


            if (count_energy % 2 == 0)
            {
                position = pos_2;
            }
            else
            {
                position = pos_4;
            }

            Instantiate(energy, position, Quaternion.identity);
            count_energy++;
        }

    }
}
