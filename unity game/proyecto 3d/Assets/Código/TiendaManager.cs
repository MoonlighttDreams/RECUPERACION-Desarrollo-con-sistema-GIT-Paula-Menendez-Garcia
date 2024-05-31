using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiendaManager : MonoBehaviour
{
    public GameObject[] Modelos;
    public int CurrentModelo =0;


    void Start()
    {
        CurrentModelo = PlayerPrefs.GetInt("Selected", 0);
        foreach (GameObject rueda in Modelos) 
        rueda.SetActive(false);

        Modelos[CurrentModelo].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeNext()
    {
        Modelos[CurrentModelo].SetActive(false);

        CurrentModelo++;
        if(CurrentModelo == Modelos.Length)
            CurrentModelo = 0;
        Modelos[CurrentModelo].SetActive(true);
        PlayerPrefs.SetInt("Selected", CurrentModelo);
    }
    public void ChangeBack()
    {
        Modelos[CurrentModelo].SetActive(false);

        CurrentModelo--;
        if (CurrentModelo == -1)
            CurrentModelo = Modelos.Length-1;
        Modelos[CurrentModelo].SetActive(true);
        PlayerPrefs.SetInt("Selected", CurrentModelo);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel");
    }
}
