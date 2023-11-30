using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howToScript : MonoBehaviour
{
    private Transform panelTransform, canvasTransform, bingoTableTransform;

    // Start is called before the first frame update
    void Start()
    {
        canvasTransform = GameObject.Find("Canvas").transform;
        panelTransform = canvasTransform.Find("howToPopup");
        panelTransform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name);
    }

    public void buttonPressed(){
    panelTransform.gameObject.SetActive(true);
    }
}
