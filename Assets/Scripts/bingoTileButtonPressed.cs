using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bingoTileButtonPressed : MonoBehaviour
{
    public GameObject spriteobject;
    private Transform panelTransform;
    string spriteName;
    TextMeshProUGUI textObj;

    private void Start()
    {
        panelTransform = GameObject.Find("Canvas").transform.Find("Tile Description Pop Up");
        Debug.Log(panelTransform.gameObject.name);
        textObj = panelTransform.Find("Text").GetComponent<TextMeshProUGUI>();
        spriteName = spriteobject.GetComponent<Image>().sprite.name;
        panelTransform.gameObject.SetActive(false);
    }

    // prints the name of the tile.
    public void bingoTilePressed()
    {
        if (descriptionModeToggle.detailMode)
        {
            Debug.Log(spriteName);
            panelTransform.gameObject.SetActive(true);
            textObj.text = spriteName;
        }
    }
}
