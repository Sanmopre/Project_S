using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Volume_Manager : MonoBehaviour
{
    public Slider volume;

    public AudioSource Music;

    void Update()
    {
        Music.volume = volume.value;
    }
}
