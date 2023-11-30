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
        generateTiles.difficulty = 0;
        generateTiles.environment = 0;
        generateTiles.size = 4;
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
                generateTiles.difficulty = 0;
                break;
            case 1:
                //medium
                generateTiles.difficulty = 1;
                break;
            case 2:
                //hard
                generateTiles.difficulty = 2;
                break;
        }
    }

    public void SizeDropdown(int index){
        switch(index){
            case 0:
                //4x4
                generateTiles.size = 4;
                break;
            case 1:
                //5x5
                generateTiles.size = 5;
                break;
            case 2:
                //6x6
                generateTiles.size = 6;
                break;
        }
    }

    public void EnvDropdown(int index){
        switch(index){
            case 0:
                //urban
                generateTiles.environment = 0;
                break;
            case 1:
                //plains
                generateTiles.environment = 1;
                break;
            case 2:
                //forest
                generateTiles.environment = 2;
                break;
            case 3:
                //desert
                generateTiles.environment = 3;
                break;
        }
    }
}
