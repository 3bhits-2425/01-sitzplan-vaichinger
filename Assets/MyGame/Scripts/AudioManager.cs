
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;

    // speichere eine Referenz in Singleton
    private AudioManager singleton;

    void Awake()
    {
        if (singleton != null && singleton != this)
        {
            Destroy(gameObject); // Entfernt doppelte Instanz
            return;
        }

        singleton = this; // Setzt die Instanz
        DontDestroyOnLoad(gameObject);

        foreach (Sound oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;

        }
    }

    public void Play(string soundName)
    {
        Debug.Log(FindSound(soundName) == null);
        FindSound(soundName).audioSource.Play();
    }

    public void Pause(string soundName)
    {
        Debug.Log(FindSound(soundName).audioSource == null);
        FindSound(soundName).audioSource.Pause();
    }

    private Sound FindSound(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                return oneSound;
            }
        }
        Debug.Log("Sound nicht gefunden");
        return null; // Rückgabe null, wenn kein Sound gefunden wird
    }

}
