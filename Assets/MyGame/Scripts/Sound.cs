using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Klasse Sound muss serializierbar sein
[System.Serializable]
public class Sound
{
    public AudioSource audioSource;
    public string name;
    public AudioClip clip;
    [Range(0f, 1f)] public float volume;
    [Range(0.1f, 3f)] public float pitch;
}
