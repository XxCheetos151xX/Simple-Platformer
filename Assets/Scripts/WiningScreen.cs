using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class WiningScreen : MonoBehaviour
{
    [SerializeField] private GameObject _WiningScreen;
    [SerializeField] private TextMeshProUGUI _FinalScore;
    [SerializeField] private TextMeshProUGUI _Timer;
    [SerializeField] private AudioSource _WinningEffect;
    [SerializeField] private GameObject PlayerButton;
    [SerializeField] private GameObject Health;
    [SerializeField] private GameObject[] Stars;
    private int _score;

     
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("flag"))
        {
            _WiningScreen.SetActive(true);
            _WinningEffect.Play();
            PlayerButton.SetActive(false);
            Health.SetActive(false);
          
            
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            _score += 1;
            _FinalScore.text = "SCORE: " + _score.ToString();
        }
        _Timer.text = "TIME: " + Time.timeSinceLevelLoad + "secs";
        if (_score <= 2)
        {
            Stars[0].SetActive(true);

        }
        else if (_score == 5)
        {
            Stars[0].SetActive(true);
            Stars[1].SetActive(true);
        }
        else if(_score > 5)
        {
            Stars[0].SetActive(true);
            Stars[1].SetActive(true);
            Stars[2].SetActive(true);
        }
    }
    
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       ;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    
}
