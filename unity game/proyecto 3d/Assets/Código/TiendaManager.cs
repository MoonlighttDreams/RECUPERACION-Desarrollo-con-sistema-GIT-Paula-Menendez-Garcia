using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


// Class tienda
public class TiendaManager : MonoBehaviour
{
    public GameObject[] Modelos;
    public int CurrentModelo =0;

    // Modelo seleccionado
    void Start()
    {
        CurrentModelo = PlayerPrefs.GetInt("Selected", 0);
        foreach (GameObject rueda in Modelos) 
        rueda.SetActive(false);

        Modelos[CurrentModelo].SetActive(true);
    }

    void Update()
    {
        
    }
    // Cambiar al siguiente modelo
    public void ChangeNext()
    {
        Modelos[CurrentModelo].SetActive(false);

        CurrentModelo++;
        if(CurrentModelo == Modelos.Length)
            CurrentModelo = 0;
        Modelos[CurrentModelo].SetActive(true);
        PlayerPrefs.SetInt("Selected", CurrentModelo);
    }
    // Cambiar al anterior modelo
    public void ChangeBack()
    {
        Modelos[CurrentModelo].SetActive(false);

        CurrentModelo--;
        if (CurrentModelo == -1)
            CurrentModelo = Modelos.Length-1;
        Modelos[CurrentModelo].SetActive(true);
        PlayerPrefs.SetInt("Selected", CurrentModelo);
    }
    // Botón jugar
    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel");
    }
}
