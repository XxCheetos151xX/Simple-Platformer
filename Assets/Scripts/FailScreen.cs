using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class FailScreen : MonoBehaviour
{
    [SerializeField] private AudioSource FailSFX; 
    private void Start()
    {
        FailSFX.Play();
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
