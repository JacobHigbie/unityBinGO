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
    SpriteRenderer spriteRenderer;
    public Button[] PlBtns;
    public GameObject[] BingoTxt;
    public Sprite[] tileSprites;
    //public Image[] images;
    public int[] MarkedSpace;
    public List<int> Numbers = new List<int>();
    //public GameManager gameManager;
    public static int difficulty;
    public static int environment;
    public static int size;
    public Image test;

    // Start is called before the first frame update
    private void Start(){
        SetupTiles();
        SetupBoard();
    }

    void SetupTiles(){
        Debug.Log(difficulty);
        Debug.Log(environment);
        Debug.Log(size);

        tiles[] tilesArr = new tiles[31];
        for(int i = 0; i<=30; i++) {
            tiles tempTile = new tiles();
            tilesArr[i] = tempTile;
            tilesArr[i].isChecked = false;
            tilesArr[i].posX = -1;
            tilesArr[i].posY = -1;
        }

        //name each tile
        tilesArr[0].objName = "Bench";
        tilesArr[1].objName = "Bird of Prey";
        tilesArr[2].objName = "Blue Vehicle";
        tilesArr[3].objName = "Boat";
        tilesArr[4].objName = "Bridge";
        tilesArr[5].objName = "Caution Stripes";
        tilesArr[6].objName = "Chain Link Fence";
        tilesArr[7].objName = "Deer";
        tilesArr[8].objName = "Dirt Road";
        tilesArr[9].objName = "Dog";
        tilesArr[10].objName = "Fallen Log";
        tilesArr[11].objName = "Fire Escape";
        tilesArr[12].objName = "Firetruck";
        tilesArr[13].objName = "Graffiti";
        tilesArr[14].objName = "Green Vehicle";
        tilesArr[15].objName = "Hard Hat";
        tilesArr[16].objName = "Jeep";
        tilesArr[17].objName = "Ladder";
        tilesArr[18].objName = "Litter";
        tilesArr[19].objName = "No Parking Sign";
        tilesArr[20].objName = "Pickett Fence";
        tilesArr[21].objName = "Pickup Truck";
        tilesArr[22].objName = "Ranch Fence";
        tilesArr[23].objName = "Recyling Logo";
        tilesArr[24].objName = "Red Vehicle";
        tilesArr[25].objName = "Roadkill";
        tilesArr[26].objName = "Railroad Tracks";
        tilesArr[27].objName = "Building With 3+ Floors";
        tilesArr[28].objName = "Trailer";
        tilesArr[29].objName = "Wildflowers";
        tilesArr[30].objName = "Yellow Vehicle";
    }

    void SetupBoard(){
        //put 0-30 on a list
        for (int i = 0; i <= 30; i++)
        {
            Numbers.Add(i);
        }

        //shuffle list
        for (int i = 0; i < Numbers.Count; i++)
        {
            int RandomNum = Random.Range(0, 30);
            int temp = Numbers[RandomNum];
            Numbers[RandomNum] = Numbers[i];
            Numbers[i] = temp;
        }

        //put images on corresponding buttons based on list
        for (int i = 0; i < tileSprites.Length; i++)
        {
            test.sprite = tileSprites[Numbers[i]];
        }

        //gameManager = FindObjectOfType<GameManager>();
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