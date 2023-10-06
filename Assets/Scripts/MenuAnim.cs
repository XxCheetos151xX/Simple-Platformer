using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnim : MonoBehaviour
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
                transform.localScale = new Vector3(1, 1, 1);
                patroldestination = 1;
            }

        }
        if (patroldestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[1].position, movemntspeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolpoints[1].position) < 0.2f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                patroldestination = 0;
            }

        }
    }
}
