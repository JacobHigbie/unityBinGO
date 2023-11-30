using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPopup : MonoBehaviour
{
    public static bool showWin;

    public GameObject winPanel;

    bool ifCont;
    
    void Start()
    {
        ifCont = false;
        showWin = false;
    }
    

    void Update()   
    {
        Debug.Log("hereis" + ifCont);
        Debug.Log("herenow" + showWin);
        if (!ifCont && showWin)
        {
            winPanel.SetActive(true);
        }
        else
        {
            winPanel.SetActive(false);
        }
    }
    
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
        ifCont = true;
    }
}
