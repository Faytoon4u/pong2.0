using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    private int GameMode; 

    public void PlayGame(int GameMode) //(int gameMode = 0)
    {
        if (GameMode == 0)
        {
            SceneManager.LoadScene("player 1");
        }
        if (GameMode == 1)
        {
            SceneManager.LoadScene("player 2");
        }
        if (GameMode == 2)
        {
            SceneManager.LoadScene("double ball");
        }
        if (GameMode == 3)
        {
            SceneManager.LoadScene("breakout");
        }
        if (GameMode == 4)
        {
            SceneManager.LoadScene("home");
}
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
