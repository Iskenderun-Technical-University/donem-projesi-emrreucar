using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Bu script, kameran�n karakteri takip etmesini sa�lar.
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vektor3 offset;

    
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}

// Bu script target olarak belirtilen karakterin pe�inden gitmesini sa�lar. 'offset' de�i�keni, kameran�n karakterden ne kadar uzakta olaca��n� belirtir. Kamera p�r�zs�z bir �ekilde takip etmek i�in 'Lerp()' fonksiyonunu kullan�l�r.
