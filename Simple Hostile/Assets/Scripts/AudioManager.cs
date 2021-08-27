using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.audioSource= gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.Clip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.looping;
        }
    }

     void Start()
    {
        Play("Theme"); 
    }
    public void Play(string name)
    {
       Sound s= Array.Find(sounds, sound => sound.Name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound : " + name + "not found !");
            return;
        }
        s.audioSource.Play();
    }
}
