using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  
public Text scoreValueText;
public float puntosPorSegundo = 1f;
public float scoreValue = 0f;

    // Al empezar, establecemos el score como 0
    void Start()
    {
        scoreValue = 0;
    }

    // Aumento de puntos por segundo
    void Update()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += puntosPorSegundo * Time.fixedDeltaTime;
        
    }
}
