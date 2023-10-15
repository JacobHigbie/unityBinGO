using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //set variables to default dropdown setting
        gameBoardScript.difficulty = 0;
        gameBoardScript.environment = 0;
        gameBoardScript.size = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //buttons to navigate screens
    public void ReturnToMenu(){
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void goToGameBoard(){
        SceneManager.LoadSceneAsync("GameBoard");
    }

    public void goToHelp(){
        SceneManager.LoadSceneAsync("HelpMenu");
    }

    //dropdown options
    public void DiffDropdown(int index){
        switch(index){
            case 0:
                //easy
                gameBoardScript.difficulty = 0;
                break;
            case 1:
                //medium
                gameBoardScript.difficulty = 1;
                break;
            case 2:
                //hard
                gameBoardScript.difficulty = 2;
                break;
        }
    }

    public void SizeDropdown(int index){
        switch(index){
            case 0:
                //4x4
                gameBoardScript.size = 4;
                break;
            case 1:
                //5x5
                gameBoardScript.size = 5;
                break;
            case 2:
                //6x6
                gameBoardScript.size = 6;
                break;
        }
    }

    public void EnvDropdown(int index){
        switch(index){
            case 0:
                //urban
                gameBoardScript.environment = 0;
                break;
            case 1:
                //plains
                gameBoardScript.environment = 1;
                break;
            case 2:
                //forest
                gameBoardScript.environment = 2;
                break;
            case 3:
                //desert
                gameBoardScript.environment = 3;
                break;
        }
    }
}
