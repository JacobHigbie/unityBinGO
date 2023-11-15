using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xButtonPressed : MonoBehaviour
{
    Transform panel;
    private void Start()
    {
        panel = transform.parent;
    }

    public void onButtonPressed()
    {
        panel.gameObject.SetActive(false);
    }
}
