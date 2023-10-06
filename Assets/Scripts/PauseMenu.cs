using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Slider MusicSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private AudioMixer MusicMixer;
    [SerializeField] private AudioMixer SFXMixer;


    private void Start()
    {
        if (PlayerPrefs.HasKey("Musicvolume"))
        {
            LoadMusicVolume();

        }
        else
        {
            ChangemusicVOlume();
            ChangeSFXVolume();
        }
    }


    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangemusicVOlume()
    {
        float MusicVolume = MusicSlider.value;
        MusicMixer.SetFloat("Music", Mathf.Log10(MusicVolume)*20);
        PlayerPrefs.SetFloat("Musicvolume", MusicVolume);
    }

    
    public void ChangeSFXVolume()
    {
        float SFXVolume = SFXSlider.value;
        SFXMixer.SetFloat("SFX", Mathf.Log10(SFXVolume)*20);
        PlayerPrefs.SetFloat("SFXvolume", SFXVolume);
    }

    public void LoadMusicVolume()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("Musicvolume");
        ChangemusicVOlume();
    }

    public void LoadSFXvolume()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXvolume");
    }
}
