using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        float volume = Mathf.Log10(PlayerPrefs.GetFloat("MasterVolume")) * 20;
        mixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MasterVolume"));
        slider.value = PlayerPrefs.GetFloat("MasterVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartCampaign()
    {
        SceneManager.LoadScene("Daan/DaanScene");
    }   
}
