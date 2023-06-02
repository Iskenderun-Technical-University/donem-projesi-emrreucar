using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Bu script, oyunda toplanabilir madeni paralarý temsil eder.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.IncreaseScore();
            Destroy(gameObject);
        }
    }
}


// Bu script madeni paralarýn oyuncu tarafýndan toplandýðýnda puaný artýrmasýný saðlar. 'OnTriggerEnter2D()' fonksiyonu, nesnenin bir tetikleyici ile etkileþime girdiðinde çalýþýr.
