using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Bu script, oyunda toplanabilir madeni paralar� temsil eder.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.IncreaseScore();
            Destroy(gameObject);
        }
    }
}


// Bu script madeni paralar�n oyuncu taraf�ndan topland���nda puan� art�rmas�n� sa�lar. 'OnTriggerEnter2D()' fonksiyonu, nesnenin bir tetikleyici ile etkile�ime girdi�inde �al���r.
