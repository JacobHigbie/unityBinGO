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
    public int[] isMarked;
    public List<int> Numbers = new List<int>();
    public static int difficulty;
    public static int environment;
    public static int size;
    public Image test;
    //public Image[] images;

    public bool bingoHad;

    // Start is called before the first frame update
    private void Start(){
        SetupTiles();
        SetupBoard();
        //bingoHad = false;
    }

    public void CheckWin(){
        //if any of these are =5, then a bingo was found
        int s1 = isMarked[0] + isMarked[5] + isMarked[10] + isMarked[15] + isMarked[20];
        int s2 = isMarked[1] + isMarked[6] + isMarked[11] + isMarked[16] + isMarked[21];
        int s3 = isMarked[2] + isMarked[7] + isMarked[12] + isMarked[17] + isMarked[22];
        int s4 = isMarked[3] + isMarked[8] + isMarked[13] + isMarked[18] + isMarked[23];
        int s5 = isMarked[4] + isMarked[9] + isMarked[14] + isMarked[19] + isMarked[24];
        int s6 = isMarked[0] + isMarked[1] + isMarked[2] + isMarked[3] + isMarked[4];
        int s7 = isMarked[5] + isMarked[6] + isMarked[7] + isMarked[8] + isMarked[9];
        int s8 = isMarked[10] + isMarked[11] + isMarked[12] + isMarked[13] + isMarked[14];
        int s9 = isMarked[15] + isMarked[16] + isMarked[17] + isMarked[18] + isMarked[19];
        int s10 = isMarked[20] + isMarked[21] + isMarked[22] + isMarked[23] + isMarked[24];
        int s11 = isMarked[0] + isMarked[6] + isMarked[12] + isMarked[18] + isMarked[24];
        int s12 = isMarked[4] + isMarked[8] + isMarked[12] + isMarked[16] + isMarked[20];   

        var board = new int[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12};

        int SumOfMarked = -1;

        foreach(var sol in board)
        {
            if(sol == 5 && bingoHad == false)
            {
                SumOfMarked++;
                Debug.Log(gameObject.name + " " + SumOfMarked);
                BingoTxt[SumOfMarked].SetActive(true);
                SceneManager.LoadSceneAsync("WinPopup");
                bingoHad = true;
            }
        }
    }   //


    void SetupTiles(){
        Debug.Log(difficulty);
        Debug.Log(environment);
        Debug.Log(size);

        tiles[] tilesArr = new tiles[51];
        for(int i = 0; i<=50; i++) {
            tiles tempTile = new tiles();
            tilesArr[i] = tempTile;
            tilesArr[i].isChecked = false;
            tilesArr[i].posX = -1;
            tilesArr[i].posY = -1;
        }

        //name each tile
        tilesArr[0].objName = "Bag";
        tilesArr[1].objName = "Ball";
        tilesArr[2].objName = "Bench";
        tilesArr[3].objName = "Billboard with Food";
        tilesArr[4].objName = "Billboard with a Person";
        tilesArr[5].objName = "Billboard with Phone Number";
        tilesArr[6].objName = "Bird of Prey";
        tilesArr[7].objName = "Blue Vehicle";
        tilesArr[8].objName = "Boat";
        tilesArr[9].objName = "Body of Water";
        tilesArr[10].objName = "Bridge";
        tilesArr[11].objName = "Cactus";
        tilesArr[12].objName = "Caution Stripes";
        tilesArr[13].objName = "Chain Link Fence";
        tilesArr[14].objName = "Cigarette";
        tilesArr[15].objName = "Deer";
        tilesArr[16].objName = "Dirt Road";
        tilesArr[17].objName = "Dog";
        tilesArr[18].objName = "Fallen Log";
        tilesArr[19].objName = "Farm Vehicle";
        tilesArr[20].objName = "Fire Escape";
        tilesArr[21].objName = "Firetruck";
        tilesArr[22].objName = "Flag";
        tilesArr[23].objName = "Graffiti";
        tilesArr[24].objName = "Green Vehicle";
        tilesArr[25].objName = "Hard Hat";
        tilesArr[26].objName = "Jeep";
        tilesArr[27].objName = "Ladder";
        tilesArr[28].objName = "Litter";
        tilesArr[29].objName = "Mile Marker";
        tilesArr[30].objName = "Mobile Home";
        tilesArr[31].objName = "No Parking Zone";
        tilesArr[32].objName = "Pickett Fence";
        tilesArr[33].objName = "Pickup Truck";
        tilesArr[34].objName = "Ranch Fence";
        tilesArr[35].objName = "Recycling Symbol";
        tilesArr[36].objName = "Red Vehicle";
        tilesArr[37].objName = "Roadkill";
        tilesArr[38].objName = "Railroad Tracks";
        tilesArr[39].objName = "Smoke";
        tilesArr[40].objName = "Statue";
        tilesArr[41].objName = "Stop Sign";
        tilesArr[42].objName = "Street Gutter";
        tilesArr[43].objName = "Stump";
        tilesArr[44].objName = "Sunglasses";
        tilesArr[45].objName = "Building with 3+ Floors";
        tilesArr[46].objName = "Traffic Cone";
        tilesArr[47].objName = "Trailer";
        tilesArr[48].objName = "Wildflowers";
        tilesArr[49].objName = "Yellow Vehicle";
        tilesArr[50].objName = "Yield Sign";
    }

    void SetupBoard(){
        //put 0-50 on a list
        for (int i = 0; i <= 50; i++)
        {
            Numbers.Add(i);
        }

        //shuffle list
        for (int i = 0; i < Numbers.Count; i++)
        {
            int RandomNum = Random.Range(0, 50);
            int temp = Numbers[RandomNum];
            Numbers[RandomNum] = Numbers[i];
            Numbers[i] = temp;
        }

        //put images on corresponding buttons based on list
        for (int i = 0; i < tileSprites.Length; i++)
        {
            test.sprite = tileSprites[Numbers[i]];
            //images[i].sprite = tileSprites[Numbers[i]];
        }

        //fill isMarked with zero
        for (int i = 0; i < isMarked.Length; i++)
        {
            isMarked[i] = 0;
        }

        //Set Bingo text to false
        for(int i = 0; i < BingoTxt.Length; i++)
        {
            BingoTxt[i].SetActive(false);
        }
    }
}