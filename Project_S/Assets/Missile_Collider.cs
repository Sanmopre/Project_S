using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Collider : MonoBehaviour
{


    public int score_sum = 5;
    public int damage;
    private GameObject obj;
    private Score_Manager score;

    public GameObject explosion;


    void Start()
    {
        obj = GameObject.Find("Score_system");
        score = obj.GetComponent<Score_Manager>();
        explosion.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

       Explode();


        Health enemy = collider.GetComponent<Health>();

        if (enemy != null)
        {
            score.score = score.score + score_sum;
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject,0.10f);

    }


    void Explode() {
        explosion.SetActive(true); 
    }



}
