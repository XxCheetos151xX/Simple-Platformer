using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth1 : MonoBehaviour
{
    private int enemyhealth = 30;
    [SerializeField] private GameObject Enemy;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            enemyhealth -= 10;
        }
        if (enemyhealth <= 0)
        {
            Enemy.SetActive(false);
        }
    }
}
