using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToStart;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToStart);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
