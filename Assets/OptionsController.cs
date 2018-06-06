using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public LevelManager levelManager;
    public Slider difficultySlider;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        difficultySlider.value = PlayerPrefManager.GetDifficulty();
        volumeSlider.value = PlayerPrefManager.getMasterVolume();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}

    public void SaveAndExit(){
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a Start");
    }

    public void SetDefaults(){
        volumeSlider.value = 0.8f;
        difficultySlider.value = 2f;
    }
}
