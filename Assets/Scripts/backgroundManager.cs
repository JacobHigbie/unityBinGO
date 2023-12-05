using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundManager : MonoBehaviour
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
        if (settingsScript.colors)
        {
            Debug.Log("heyo");
            spriteObject.GetComponent<SpriteRenderer>().sprite = light;
        }
        else
        {
            spriteObject.GetComponent<SpriteRenderer>().sprite = dark;
        }
    }
}
