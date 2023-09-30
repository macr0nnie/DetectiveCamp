using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // Singleton pattern
    
    public AudioSource backgroundMusic;
    public AudioSource sfxSource;

    private void Awake()
    {
        // Ensure only one instance of the AudioManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Play background music
    public void PlayBackgroundMusic(AudioClip music)
    {
        backgroundMusic.clip = music;
        backgroundMusic.Play();
    }

    // Play sound effects
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    // Adjust volume
    public void SetVolume(float volume)
    {
        backgroundMusic.volume = volume;
        sfxSource.volume = volume;
    }
}
