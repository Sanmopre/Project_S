using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_fixes : MonoBehaviour
{
    public Transform camera_pos;
    void Start()
    {
        
    }

    void Update()
    {
        camera_pos.rotation = Quaternion.Euler(Vector3.zero);
    }
}
