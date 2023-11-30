using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public GameObject spriteObject;
    public Sprite light, dark;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //buttons to move between screens
    public void PlayGame(){
        SceneManager.LoadSceneAsync("GameSetupScreen");
    }

    public void EnterSettings(){
        SceneManager.LoadSceneAsync("SettingsScreen");
    }

    public void EnterLogin(){
        SceneManager.LoadSceneAsync("LoginScreen");
    }
}
