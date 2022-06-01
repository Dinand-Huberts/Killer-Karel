using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {

    }

    public void SetLevel(float sliderValue)
    {
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
        float volume = Mathf.Log10(sliderValue) * 20;
        mixer.SetFloat("MusicVol", volume);
    }
}
