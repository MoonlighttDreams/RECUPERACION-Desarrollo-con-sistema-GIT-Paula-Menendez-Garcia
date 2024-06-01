using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorRueda : MonoBehaviour
{
    public GameObject[] Ruedas;
    public int CurrentModelo = 0;


    // Rueda activa
    void Start()
    {
        CurrentModelo = PlayerPrefs.GetInt("Selected", 0);
        foreach (GameObject rueda in Ruedas)
            rueda.SetActive(false);

        Ruedas[CurrentModelo].SetActive(true);
    }
}
