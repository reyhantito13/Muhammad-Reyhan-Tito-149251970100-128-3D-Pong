using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game");
    }
    public void LoadHowToPlayScene()
    {
        SceneManager.LoadScene("How To Play");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void ExitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}
