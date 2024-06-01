using UnityEngine.SceneManagement;
using UnityEngine;


public class botones : MonoBehaviour
{
    // Boton replay
   public void Replay()
    {
        SceneManager.LoadScene("Nivel");
    }

    // Boton salir
    public void Quit()
    {
        Application.Quit();
    }
}