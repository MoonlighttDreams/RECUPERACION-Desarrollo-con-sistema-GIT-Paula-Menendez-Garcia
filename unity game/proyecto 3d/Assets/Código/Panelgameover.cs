using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panelgameover : MonoBehaviour
{
   

    public static bool GameStarted;
    public GameObject textoEmpezar;

    

    void Start()
    {
      
        Time.timeScale = 1;
        GameStarted = false;


    }



    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            GameStarted = true;
            Destroy(textoEmpezar);
        }
    }
}

