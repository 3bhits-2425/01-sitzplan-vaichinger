using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    private AudioSource myAudioSource;
    private GameObject playPauseButton; // Der Button
    private TMP_Text playPauseButtonText; // Der Text auf dem Button

    // Start is called before the first frame update
    void Awake()
    {
        // get the Audio Source Component
        myAudioSource = GetComponent<AudioSource>();
        // 1. Schritt :finden des PlayPause Button
        playPauseButton = GameObject.Find("PlayPauseButton");

        // 2. Schritt: finde das Textfeld des PlayPause Button
        playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();
    }

    public void Update()
    {
        if (myAudioSource.isPlaying)
        {
            playPauseButtonText.text = "Pause";
        } else if (myAudioSource.isPlaying == false) 
        {
            playPauseButtonText.text = "Play";
        }
    }

    public void PlayAudio()
    {
        //Audiosource.play
        myAudioSource.Play();
    }
    public void PauseAudio()
    {
        myAudioSource.Pause();
    }
    public void StopAudio()
    {
        myAudioSource.Stop();
    }
    public void PlayPause()
    {
        if (myAudioSource.isPlaying)
        {
            myAudioSource.Pause();
            //audioIsPlaying = false;
            // playPauseButtonText.text = "Play";
        }
        else
        {
            myAudioSource.Play();
            //audioIsPlaying = true;
            // playPauseButtonText.text = "Pause";
        }
    }
}
