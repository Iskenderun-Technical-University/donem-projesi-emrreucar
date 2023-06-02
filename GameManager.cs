using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Bu script, oyun yönetimini saðlar.

    public static GameManager instance;

    public int score = 0;
    public Text scoreText;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}


// Bu script, oyun yönetimini saðlar. 'score' deðiþkeni, oyuncunun puanýný tutar. 'IncreaseScore()' fonksiyonu, puaný artýrýr ve skor metnini günceller.
