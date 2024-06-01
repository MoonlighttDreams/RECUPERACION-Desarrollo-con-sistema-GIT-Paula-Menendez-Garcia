using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Boton jugar
    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel");
    }

    // Boton salir
    public void QuitGame()
    {
        Application.Quit();
    }

    // Boton tienda
    public void TiendaGame()
    {
        SceneManager.LoadScene("Tienda");
    }

}