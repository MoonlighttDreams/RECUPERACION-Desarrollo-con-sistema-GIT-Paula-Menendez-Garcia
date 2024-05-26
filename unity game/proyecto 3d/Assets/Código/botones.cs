using UnityEngine.SceneManagement;
using UnityEngine;

public class botones : MonoBehaviour
{
   public void Replay()
    {
        SceneManager.LoadScene("Nivel");
    }

    public void Quit()
    {
        Application.Quit();
    }
}