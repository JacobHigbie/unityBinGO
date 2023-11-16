using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPopup : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadSceneAsync("GameSetupScreen");
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void Continue()
    {
        SceneManager.LoadSceneAsync("GameBoard");
    }
}
