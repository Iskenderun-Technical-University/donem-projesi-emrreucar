using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Bu script, kameranýn karakteri takip etmesini saðlar.
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

// Bu script target olarak belirtilen karakterin peþinden gitmesini saðlar. 'offset' deðiþkeni, kameranýn karakterden ne kadar uzakta olacaðýný belirtir. Kamera pürüzsüz bir þekilde takip etmek için 'Lerp()' fonksiyonunu kullanýlýr.
