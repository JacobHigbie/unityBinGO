using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiles{
    public bool isChecked;
    public string objName;
    public int posX;
    public int posY;
}

public class gameBoardScript : MonoBehaviour
{
    //make public variables
    public static int difficulty;
    public static int environment;
    public static int size;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(difficulty);
        Debug.Log(environment);
        Debug.Log(size);

        tiles[] tilesArr = new tiles[27];
        for(int i = 0; i<27; i++) {
            tiles tempTile = new tiles();
            tilesArr[i] = tempTile;
            tilesArr[i].isChecked = false;
            tilesArr[i].posX = -1;
            tilesArr[i].posY = -1;
        }

        //name each tile + tie them to corresponding .png
        tilesArr[0].objName = "Blue Vehicle";
        tilesArr[1].objName = "Boat";
        tilesArr[2].objName = "Caution Stripes";
        tilesArr[3].objName = "Chain Link Fence";
        tilesArr[4].objName = "Dirt Road";
        tilesArr[5].objName = "Dog";
        tilesArr[6].objName = "Fallen Log";
        tilesArr[7].objName = "Fire Escape";
        tilesArr[8].objName = "Firetruck";
        tilesArr[9].objName = "Graffiti";
        tilesArr[10].objName = "Green Vehicle";
        tilesArr[11].objName = "Hard Hat";
        tilesArr[12].objName = "Jeep";
        tilesArr[13].objName = "Ladder";
        tilesArr[14].objName = "Litter";
        tilesArr[15].objName = "No Parking Zone";
        tilesArr[16].objName = "Pickett Fence";
        tilesArr[17].objName = "Pickup Truck";
        tilesArr[18].objName = "Ranch Fence";
        tilesArr[19].objName = "Recycling Logo";
        tilesArr[20].objName = "Red Vehicle";
        tilesArr[21].objName = "Roadkill";
        tilesArr[22].objName = "Railroad Tracks";
        tilesArr[23].objName = "Building With 3+ Floors";
        tilesArr[24].objName = "Trailer";
        tilesArr[25].objName = "Wildflowers";
        tilesArr[26].objName = "Yellow Vehicle";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ReturnToMenu(){
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
