using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaform : MonoBehaviour
{
    // Bu script, hareketli platformlarý kontrol eder.
    public Transform[] waypoints;
    public float moveSpeed = 2f;

    private int currentWaypointIndex = 0;

    
    void Update()
    {
        if (transform.position != waypoints[currentWaypointIndex].position)
        {
            Vector2 newPosition = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(newPosition);
        }
        else
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}


// Bu script, platformlarýn belirtilen yol noktalarýna hareket etmesini saðlar. 'waypoints' dizisi, platformun hareket edeceði noktalarý içerir. 'moveSpeed' deðiþkeni, platformun hareket hýzýný belirler.
