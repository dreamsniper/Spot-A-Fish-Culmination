using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene-1");
        Debug.Log("pressed");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Stage-1");
        Debug.Log("pressed");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("pressed");
    }


}
