using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class descriptionModeToggle : MonoBehaviour
{
    public static bool detailMode; // stores wether the description mode is on or off
    TextMeshProUGUI textObj;

    private void Start()
    {
        textObj = transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        textObj.text = "Mode: Mark";
        detailMode = false;
    }

    private void Update()
    {
        //Debug.Log(detailMode);
    }

    // toggles Description mode for the bingo board
    public void DescriptionModeToggle()
    {
        detailMode = !detailMode;
        Debug.Log(detailMode);
        if (detailMode)
        {
            textObj.text = "Mode: Description";
        }
        else
        {
            textObj.text = "Mode: Mark";
        }
    }
}
