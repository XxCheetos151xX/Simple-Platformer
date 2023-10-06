using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    [SerializeField]private Rigidbody2D bullet_rb;
    [SerializeField] private float bullet_speed;
    void Start()
    {

        bullet_rb.velocity = transform.right * bullet_speed;
        Destroy(gameObject, 2);
        
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }



}
