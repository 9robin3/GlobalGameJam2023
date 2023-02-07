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

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.Play();
    }

    public void PlayEventMusic(Ingridient ingridient)
    {
        audioSource.Pause();

        switch (ingridient)
        {
            case Ingridient.camomille:
                audioSource.PlayOneShot(camomilleMusic);
                break;
            case Ingridient.chicory:
                audioSource.PlayOneShot(chicoryMusic);
                break;
            case Ingridient.honey:
                audioSource.PlayOneShot(honeyMusic);
                break;
            case Ingridient.mushroom:
                audioSource.PlayOneShot(mushroomMusic);
                break;
            case Ingridient.gravel:
                audioSource.PlayOneShot(gravelMusic);
                break;
            case Ingridient.empty:
                break;
            case Ingridient.random:
                break;
            case Ingridient.tapioca:
                audioSource.PlayOneShot(bobaMusic);
                break;
            case Ingridient.vanilla:
                audioSource.PlayOneShot(vanillaMusic);
                break;
            case Ingridient.water:
                audioSource.PlayOneShot(waterMusic);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}
