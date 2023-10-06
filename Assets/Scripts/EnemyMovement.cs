using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] patrolpoints;
    [SerializeField] private float movemntspeed;
    private int patroldestination;

    void Update()
    {
        if (patroldestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[0].position, movemntspeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolpoints[0].position) < 0.2f)
            {
                transform.localScale =new Vector3(-1, 1, 1);
                patroldestination = 1;
            }

        }
        if (patroldestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[1].position, movemntspeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolpoints[1].position) < 0.2f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                patroldestination = 0;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            if(patroldestination == 0)
            {
                patroldestination = 1;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (patroldestination ==1)
            {
                patroldestination = 0;
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }


}
