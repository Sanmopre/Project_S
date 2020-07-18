using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities_manager : MonoBehaviour
{

    public Sprite Ultimate_Sprite;
    public Sprite Normal_Sprite;
    public bool in_ultimate = false;
    public PlayerMovement mov;

    void Update()
    {

        if (mov.sprinting)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ultimate_Sprite;
        }
        else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal_Sprite;
        }

    }
}
