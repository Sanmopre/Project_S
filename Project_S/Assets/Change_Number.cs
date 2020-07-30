using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Change_Number : MonoBehaviour
{

    private Abilities_manager ab;
    private GameObject ob;
    public Text text;



    public 

    void Start()
    {
        ob = GameObject.Find("Character");
        ab = ob.GetComponent<Abilities_manager>();
    }

    // Update is called once per frame
    void Update()
    {
   
        text.text = ab.blade_counter.ToString();
    }
}
