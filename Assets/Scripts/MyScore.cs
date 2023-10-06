using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _ScoreText;
    private int myscore;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            myscore += 1;
            PlayerPrefs.SetInt("Score", myscore);
            PlayerPrefs.Save();
            _ScoreText.text = "X" + PlayerPrefs.GetInt("Score").ToString();
        }
        
        
    }
}
