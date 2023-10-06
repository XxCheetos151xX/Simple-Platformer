using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform shooting_pos;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private AudioSource _ShootSound;
    [SerializeField] private Transform _Player;
    public void Shoot()
    {
        Instantiate(bulletprefab, shooting_pos.position, transform.rotation);
        _ShootSound.Play();
       
    }
}