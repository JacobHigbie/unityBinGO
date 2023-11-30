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
        if (settingsScript.colors)
        {
            spriteObject.GetComponent<SpriteRenderer>().sprite = light;
        }
        else
        {
            spriteObject.GetComponent<SpriteRenderer>().sprite = dark;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
