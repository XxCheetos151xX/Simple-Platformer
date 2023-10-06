using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{
    private int playerHealth;
    [SerializeField] private GameObject FailScreen;
    [SerializeField] private GameObject Playerbuttons;
    [SerializeField] private GameObject Heart1;
    [SerializeField] private GameObject Heart2;
    [SerializeField] private GameObject Heart3;


    private void Start()
    {
        playerHealth = 150;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 50;
        }
    }
    private void Update()
    {

        if (playerHealth == 100)
        {
            Heart1.SetActive(false);
        }
        if (playerHealth == 50)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
        }

        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);
            FailScreen.SetActive(true);
            Playerbuttons.SetActive(false);
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);

        }
    }
}


