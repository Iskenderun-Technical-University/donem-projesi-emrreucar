using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Bu script, oyun y�netimini sa�lar.

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


// Bu script, oyun y�netimini sa�lar. 'score' de�i�keni, oyuncunun puan�n� tutar. 'IncreaseScore()' fonksiyonu, puan� art�r�r ve skor metnini g�nceller.
