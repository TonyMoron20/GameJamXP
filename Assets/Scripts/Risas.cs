using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risas : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip[] risas;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        RandomSound();
    }

    private void RandomSound()
    {
        _audioSource.clip = risas[Random.Range(0, risas.Length)];
    }
}
