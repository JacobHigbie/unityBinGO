using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bingoBoardTileDescription : MonoBehaviour
{
    public GameObject test;
    public tiles tile; // gets the tile that is being described

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // prints the name of the tile.
    public void TileDescription()
    {
        if (descriptionModeToggle.detailMode)
        {
            Debug.Log(tile.objName);
        }
    }
}
