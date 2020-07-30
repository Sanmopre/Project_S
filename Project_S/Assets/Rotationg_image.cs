using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationg_image : MonoBehaviour
{

    private Transform blade;
    public Rigidbody2D rb;
    public float rotation_speed;
    // Update is called once per frame
    void Update()
    {
        rb.rotation = rb.rotation + rotation_speed;
    }

}
