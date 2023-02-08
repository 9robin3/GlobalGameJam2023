using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioClip mainMusic;
    [SerializeField] AudioClip bobaMusic;
    [SerializeField] AudioClip camomilleMusic;
    [SerializeField] AudioClip chicoryMusic;
    [SerializeField] AudioClip gravelMusic;
    [SerializeField] AudioClip honeyMusic;
    [SerializeField] AudioClip mushroomMusic;
    [SerializeField] AudioClip vanillaMusic;
    [SerializeField] AudioClip waterMusic;

    AudioSource mainAudioSource;
    AudioSource clipAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        if (audioSources[0].playOnAwake)
        {
            mainAudioSource = audioSources[0];
            clipAudioSource = audioSources[1];
        }
        else 
        {
            mainAudioSource = audioSources[1];
            clipAudioSource = audioSources[0];
        }
    }

    public void PlayEventMusic(Ingridient ingridient)
    {
        //mainAudioSource.Pause();
        clipAudioSource.Stop();

        switch (ingridient)
        {
            case Ingridient.camomille:
                clipAudioSource.PlayOneShot(camomilleMusic);
                break;
            case Ingridient.chicory:
                clipAudioSource.PlayOneShot(chicoryMusic);
                break;
            case Ingridient.honey:
                clipAudioSource.PlayOneShot(honeyMusic);
                break;
            case Ingridient.mushroom:
                clipAudioSource.PlayOneShot(mushroomMusic);
                break;
            case Ingridient.gravel:
                clipAudioSource.PlayOneShot(gravelMusic);
                break;
            case Ingridient.empty:
                break;
            case Ingridient.random:
                break;
            case Ingridient.tapioca:
                clipAudioSource.PlayOneShot(bobaMusic);
                break;
            case Ingridient.vanilla:
                clipAudioSource.PlayOneShot(vanillaMusic);
                break;
            case Ingridient.water:
                clipAudioSource.PlayOneShot(waterMusic);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(!clipAudioSource.isPlaying)
        //{
        //    mainAudioSource.UnPause();
        //}
    }
}
