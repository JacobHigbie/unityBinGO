using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsScript : MonoBehaviour
{
    public static bool colors = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToMenu(){
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void modedropdown(int index)
    {
        switch (index)
        {
            case 0:
                //light mode
                colors = true;
                Debug.Log(colors);
                break;
            case 1:
                //dark mode
                colors = false;
                Debug.Log(colors);
                break;
        }
    }
}
