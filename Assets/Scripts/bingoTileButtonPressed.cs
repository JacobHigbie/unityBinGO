using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bingoTileButtonPressed : MonoBehaviour
{
    public int buttonElementNumber;
    public GameObject spriteobject;
    private Transform panelTransform, canvasTransform, bingoTableTransform;
    string spriteName;
    TextMeshProUGUI textObj;

    private void Start()
    {
        canvasTransform = GameObject.Find("Canvas").transform;
        panelTransform = canvasTransform.Find("Tile Description Pop Up");
        bingoTableTransform = canvasTransform.Find("bingoTable");
//        Debug.Log(panelTransform.gameObject.name);
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
        else
        {
            bingoTableTransform.gameObject.GetComponent<generateTiles>().isMarked[buttonElementNumber] = 1;
            
        }
    }
}
