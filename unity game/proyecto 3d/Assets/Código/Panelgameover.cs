using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Panelgameover : MonoBehaviour
{
   

    public static bool GameStarted;
    public GameObject textoEmpezar;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static int numberOfCoins;
    public Text TextoMonedas;

    void Start()
    {
      
        Time.timeScale = 1;
        GameStarted = false;
        gameOver = false;
        numberOfCoins = 1;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameStarted = true;
            Destroy(textoEmpezar);
        }
        TextoMonedas.text = "Monedas:" + numberOfCoins;
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }


    }
}
