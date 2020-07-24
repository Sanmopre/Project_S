using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemy_shooter;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawn_rate = 2f;
    public float spawn_rate_shooter = 2f;
    public float increase_rate;

    float nextSpawn = 0.0f;
    float nextSpawn_s = 0.0f;




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


        if (Time.time > nextSpawn_s)
        {
            nextSpawn_s = Time.time + spawn_rate_shooter;
            randX = Random.Range(-20, 20);
            randY = Random.Range(2, -35);

            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy_shooter, whereToSpawn, Quaternion.identity);

        }


        
        spawn_rate = spawn_rate - increase_rate;
        spawn_rate_shooter = spawn_rate_shooter - increase_rate;
    }
}
