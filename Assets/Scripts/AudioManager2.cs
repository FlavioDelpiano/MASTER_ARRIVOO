using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager2 : MonoBehaviour
{
    public Sound sound;

    
    void Awake()
    {


        sound.source = gameObject.AddComponent<AudioSource>();
        sound.source.clip = sound.clip;

        sound.source.volume = sound.volume;
        sound.source.pitch = sound.pitch;
        sound.source.loop = sound.loop;
        
    }

   

    public void PlayClacson()
    {
        
        sound.source.Play();

    }
}
