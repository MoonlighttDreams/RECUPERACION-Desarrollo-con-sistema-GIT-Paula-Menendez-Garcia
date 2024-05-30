using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  
public Text scoreValueText;
public float puntosPorSegundo = 1f;
public float scoreValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += puntosPorSegundo * Time.fixedDeltaTime;
        
    }
}
