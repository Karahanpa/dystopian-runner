using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        ScoreManager.ResetScore();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
