using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiles{
    public bool isChecked;
    public string objName;
    public int posX;
    public int posY;
}

public class generateTiles : MonoBehaviour
{
    public Button[] PlBtns;
    public GameObject[] BingoTxt;
    public Sprite[] sprites;
    public int[] MarkedSpace;
    public List<int> Numbers = new List<int>();
    public GameManager gameManager;
    public static int difficulty;
    public static int environment;
    public static int size;

    // Start is called before the first frame update
    private void Start(){
        SetupTiles();
        SetupBoard();
    }

    void SetupTiles(){
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

        //name each tile + tie them to corresponding png
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

    void SetupBoard(){
        //put 1-27 on a list
        for (int i = 0; i < 27; i++)
        {
            Numbers.Add(i + 1);
        }

        //shuffle list
        for (int i = 0; i < Numbers.Count; i++)
        {
            int RandomNum = Random.Range(1, 27);
            int temp = Numbers[RandomNum];
            Numbers[RandomNum] = Numbers[i];
            Numbers[i] = temp;
        }

        //put images on corresponding buttons based on list
        for (int i = 0; i < sprites.Length; i++)
        {
            //TxtBox[i].text = Numbers[i].ToString();
        }

        gameManager = FindObjectOfType<GameManager>();
        //fill Marked Spaces with zeroes
        for (int i = 0; i < MarkedSpace.Length; i++)
        {
            MarkedSpace[i] = 0;
        }

        //Set Bingo text to false
        for(int i = 0; i < BingoTxt.Length; i++)
        {
            BingoTxt[i].SetActive(false);
        }
    }

    public void WinCondition(){
        //Horizontal
        int s1 = MarkedSpace[0] + MarkedSpace[1] + MarkedSpace[2] + MarkedSpace[3] + MarkedSpace[4];
        int s2 = MarkedSpace[5] + MarkedSpace[6] + MarkedSpace[7] + MarkedSpace[8] + MarkedSpace[9];
        int s3 = MarkedSpace[10] + MarkedSpace[11] + MarkedSpace[12] + MarkedSpace[13] + MarkedSpace[14];
        int s4 = MarkedSpace[15] + MarkedSpace[16] + MarkedSpace[17] + MarkedSpace[18] + MarkedSpace[19];
        int s5 = MarkedSpace[20] + MarkedSpace[21] + MarkedSpace[22] + MarkedSpace[23] + MarkedSpace[24];
        //Vertical
        int s6 = MarkedSpace[0] + MarkedSpace[5] + MarkedSpace[10] + MarkedSpace[15] + MarkedSpace[20];
        int s7 = MarkedSpace[1] + MarkedSpace[6] + MarkedSpace[11] + MarkedSpace[16] + MarkedSpace[21];
        int s8 = MarkedSpace[2] + MarkedSpace[7] + MarkedSpace[12] + MarkedSpace[17] + MarkedSpace[22];
        int s9 = MarkedSpace[3] + MarkedSpace[8] + MarkedSpace[13] + MarkedSpace[18] + MarkedSpace[23];
        int s10 = MarkedSpace[4] + MarkedSpace[9] + MarkedSpace[14] + MarkedSpace[19] + MarkedSpace[24];

        //Diagonal
        int s11 = MarkedSpace[0] + MarkedSpace[6] + MarkedSpace[12] + MarkedSpace[18] + MarkedSpace[24];
        int s12 = MarkedSpace[4] + MarkedSpace[8] + MarkedSpace[12] + MarkedSpace[16] + MarkedSpace[20];   

        var solution = new int[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12};

        int SumOfMarkedSpace = -1;

        foreach(var sol in solution)
        {
            if(sol == 5)
            {
                SumOfMarkedSpace++;
                Debug.Log(gameObject.name + " " + SumOfMarkedSpace);
                BingoTxt[SumOfMarkedSpace].SetActive(true);
            }
        }
    }
}