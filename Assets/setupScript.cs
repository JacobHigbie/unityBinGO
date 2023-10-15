using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

    //dropdown options
    public void DiffDropdown(int index){
        switch(index){
            case 0:
                //easy
                break;
            case 1:
                //medium
                break;
            case 2:
                //hard
                break;
        }
    }

    public void SizeDropdown(int index){
        switch(index){
            case 0:
                //4x4
                break;
            case 1:
                //5x5
                break;
            case 2:
                //6x6
                break;
        }
    }

    public void EnvDropdown(int index){
        switch(index){
            case 0:
                //urban
                break;
            case 1:
                //plains
                break;
            case 2:
                //forest
                break;
            case 3:
                //desert
                break;
        }
    }
}
