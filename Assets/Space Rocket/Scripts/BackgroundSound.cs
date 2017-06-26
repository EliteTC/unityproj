using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour {

    public AudioClip music = null;
    AudioSource musicSource = null;
    void Start()
    {
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = music;
        musicSource.loop = true;
        musicSource.volume = 0.05f;
        musicSource.priority = 255;

     
    }

    void FixedUpdate()
    {
        if (!musicSource.isPlaying) musicSource.Play();
    }
}
