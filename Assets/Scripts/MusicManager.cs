using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    private void OnLevelWasLoaded(int level)
    {
        AudioClip audioClip = levelMusicChangeArray[level];
        Debug.Log("Playing clip: " + audioClip);
        if (audioClip){
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void ChangeVolume(float vol){
        audioSource.volume = vol;
    }
}
