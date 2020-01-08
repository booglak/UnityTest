using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AudioControll
{

public class AudioController : MonoBehaviour
{

    public AudioSource audioPlayer;
    public AudioClip zaDruzbu;
    

    // Start is called before the first frame update
    public AudioController(AudioSource aSource)
    {
        audioPlayer = aSource;
        zaDruzbu = Resources.Load<AudioClip>("Audio/za_druzhbu");
    }

    public void audioZaDruzhbu(){
        audioPlayer.clip = zaDruzbu;
        audioPlayer.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
