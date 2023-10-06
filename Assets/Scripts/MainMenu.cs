using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private Slider SFXslider;
    [SerializeField] private Slider _volumeslider;
    [SerializeField] private AudioMixer _Musicmixer;
    [SerializeField] private AudioMixer _SFXMixer;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Musicvolume"))
        {
            LoadmusicVolume();

        }
        else
        {
            ControlVolume();
        }
        if (PlayerPrefs.HasKey("SFXvolume"))
        {
            LoadSFXVolume();

        }
        else
        {
            ControlSFXVolume();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ControlVolume()
    {
        float musicVolume = _volumeslider.value;
        _Musicmixer.SetFloat("Music", Mathf.Log10(musicVolume) * 20);
        PlayerPrefs.SetFloat("Musicvolume", musicVolume);
    }
    public void LoadmusicVolume()
    {
        _volumeslider.value = PlayerPrefs.GetFloat("Musicvolume");
        ControlVolume();
    }
    public void ControlSFXVolume()
    {
        float SFXVolume = SFXslider.value;
        _SFXMixer.SetFloat("SFX", Mathf.Log10(SFXVolume) * 20);
        PlayerPrefs.SetFloat("SFXvolume", SFXVolume);
    }
    public void LoadSFXVolume()
    {
        SFXslider.value = PlayerPrefs.GetFloat("SFXvolume");
        ControlVolume();
    }
}
