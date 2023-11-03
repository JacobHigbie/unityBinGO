using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class descriptionModeToggle : MonoBehaviour
{
    public static bool detailMode; // stores wether the description mode is on or off

    private void Start()
    {
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
    }
}
