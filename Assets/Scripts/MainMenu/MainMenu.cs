using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // estas dos funciones solo funcionana desde los clicks de los botones
    public void OnPlayerButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void OnQuitButtonClicked()
    {
        Debug.Log("Cerrando Juego...");
        Application.Quit();
    }
}
