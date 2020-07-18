using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
