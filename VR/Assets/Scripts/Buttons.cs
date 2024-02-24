using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public AudioSource music;
    private bool MusicFlag = true;

    private void Update()
    {
        if (MusicFlag == true) 
        {
            music.Play();
        }
        if (MusicFlag == false)
        {
           music.Stop();
        }
    }
    private void StopMusic()
    {
        if (MusicFlag == true)
        {
            MusicFlag = false;
        }
        else
        {
            MusicFlag = true;
        }
    }
}
