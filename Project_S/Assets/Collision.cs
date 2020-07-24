using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public int damage;
    private GameObject obj;
    public Score_Manager score;


    private void Start()
    {
        obj = GameObject.Find("Score_system");
        score = obj.GetComponent<Score_Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            score.score = score.score + 10;
        }
        else {

        }

        Destroy(gameObject);
    }
}
