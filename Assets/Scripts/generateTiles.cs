using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class tiles{
    public int diffUrban = 0;
    public int diffPlains = 0;
    public int diffForest = 0;
    public int diffDesert = 0;
}

public class generateTiles : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Button[] PlBtns;
    public GameObject[] BingoTxt;
    public Sprite[] tileSprites;
    public Sprite[] markerSprites;
    public int[] isMarked;
    public List<int> Numbers = new List<int>();
    public List<int> RefNumbers = new List<int>();
    public static int difficulty;
    public static int environment;
    public static int size;
    public bool bingoHad;
    public List<GameObject> spriteObj;
    public tiles[] tilesArr = new tiles[100];
    public GameObject button00, bingoTable;
    public Transform bingoTableTransform, canvasTransform;
    public int numButtons;
    public static bool newGame = true;

    // Start is called before the first frame update
    private void Start(){
        if(newGame){
            numButtons = size*size;
            isMarked = new int[numButtons];
            spriteObj = new List<GameObject>();
            //bingoTable.GetComponent<RectTransform>().position = new Vector3(0, 60, 0);
            bingoTableTransform = canvasTransform;
            SetupTiles();
            makeButtons();
            SetupBoard();
        }else{
            newGame = true;
        }
    }

    private void Update()
    {
        for(int i=0; i<numButtons; i++){
            if(isMarked[i] == 1){
                spriteObj[i].gameObject.transform.GetChild(1).GetComponent<Image>().sprite = markerSprites[1];
            }else{
                spriteObj[i].gameObject.transform.GetChild(1).GetComponent<Image>().sprite = markerSprites[0];
            }
        }
        CheckWin();
    }

    public void makeButtons(){      //fill the table with button objects
        bingoTableTransform = bingoTable.transform;
        for(int i=0; i<numButtons; i++){
            GameObject tempButton = Instantiate(button00, bingoTableTransform);
            tempButton.GetComponent<bingoTileButtonPressed>().buttonElementNumber = i;
            spriteObj.Add(tempButton);
        }
    }

    public void CheckWin(){
        if(size == 4){
            //if any of these are =4, then a bingo was found
            int case1 = isMarked[0] + isMarked[4] + isMarked[8] + isMarked[12];
            int case2 = isMarked[1] + isMarked[5] + isMarked[9] + isMarked[13];
            int case3 = isMarked[2] + isMarked[6] + isMarked[10] + isMarked[14];
            int case4 = isMarked[3] + isMarked[7] + isMarked[11] + isMarked[15];
            int case5 = isMarked[0] + isMarked[1] + isMarked[2] + isMarked[3];
            int case6 = isMarked[4] + isMarked[5] + isMarked[6] + isMarked[7];
            int case7 = isMarked[8] + isMarked[9] + isMarked[10] + isMarked[11];
            int case8 = isMarked[12] + isMarked[13] + isMarked[14] + isMarked[15];
            int case9 = isMarked[0] + isMarked[5] + isMarked[10] + isMarked[15];
            int case10 = isMarked[3] + isMarked[6] + isMarked[9] + isMarked[12];   

            var board = new int[] { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10};


            foreach(var sol in board)
            {
                if(sol == 4 && bingoHad == false)
                {
                    bingoHad = true;
                    WinPopup.showWin = true;
                }
            }
        
        }else if(size == 5){
            //if any of these are =5, then a bingo was found
            int case1 = isMarked[0] + isMarked[5] + isMarked[10] + isMarked[15] + isMarked[20];
            int case2 = isMarked[1] + isMarked[6] + isMarked[11] + isMarked[16] + isMarked[21];
            int case3 = isMarked[2] + isMarked[7] + isMarked[12] + isMarked[17] + isMarked[22];
            int case4 = isMarked[3] + isMarked[8] + isMarked[13] + isMarked[18] + isMarked[23];
            int case5 = isMarked[4] + isMarked[9] + isMarked[14] + isMarked[19] + isMarked[24];
            int case6 = isMarked[0] + isMarked[1] + isMarked[2] + isMarked[3] + isMarked[4];
            int case7 = isMarked[5] + isMarked[6] + isMarked[7] + isMarked[8] + isMarked[9];
            int case8 = isMarked[10] + isMarked[11] + isMarked[12] + isMarked[13] + isMarked[14];
            int case9 = isMarked[15] + isMarked[16] + isMarked[17] + isMarked[18] + isMarked[19];
            int case10 = isMarked[20] + isMarked[21] + isMarked[22] + isMarked[23] + isMarked[24];
            int case11 = isMarked[0] + isMarked[6] + isMarked[12] + isMarked[18] + isMarked[24];
            int case12 = isMarked[4] + isMarked[8] + isMarked[12] + isMarked[16] + isMarked[20];   

            var board = new int[] { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12};


            foreach(var sol in board)
            {
                if(sol == 5 && bingoHad == false)
                {
                    bingoHad = true;
                    WinPopup.showWin = true;
                }
            }
        }else if (size == 6){
            //if any of these are =6, then a bingo was found
            int case1 = isMarked[0] + isMarked[6] + isMarked[12] + isMarked[18] + isMarked[24] + isMarked[30];
            int case2 = isMarked[1] + isMarked[7] + isMarked[13] + isMarked[19] + isMarked[25] + isMarked[31];
            int case3 = isMarked[2] + isMarked[8] + isMarked[14] + isMarked[20] + isMarked[26] + isMarked[32];
            int case4 = isMarked[3] + isMarked[9] + isMarked[15] + isMarked[21] + isMarked[27] + isMarked[33];
            int case5 = isMarked[4] + isMarked[10] + isMarked[16] + isMarked[22] + isMarked[28] + isMarked[34];
            int case6 = isMarked[5] + isMarked[11] + isMarked[17] + isMarked[23] + isMarked[29] + isMarked[35];
            int case7 = isMarked[0] + isMarked[1] + isMarked[2] + isMarked[3] + isMarked[4] + isMarked[5];
            int case8 = isMarked[6] + isMarked[7] + isMarked[8] + isMarked[9] + isMarked[10] + isMarked[11];
            int case9 = isMarked[12] + isMarked[13] + isMarked[14] + isMarked[15] + isMarked[16] + isMarked[17];
            int case10 = isMarked[18] + isMarked[19] + isMarked[20] + isMarked[21] + isMarked[22] + isMarked[23];
            int case11 = isMarked[24] + isMarked[25] + isMarked[26] + isMarked[27] + isMarked[28] + isMarked[29];
            int case12 = isMarked[30] + isMarked[31] + isMarked[32] + isMarked[33] + isMarked[34] + isMarked[35];
            int case13 = isMarked[0] + isMarked[7] + isMarked[14] + isMarked[21] + isMarked[28] + isMarked[35];
            int case14 = isMarked[5] + isMarked[10] + isMarked[15] + isMarked[20] + isMarked[25] + isMarked[30]; 

            var board = new int[] { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14};

            foreach(var sol in board)
            {
                if(sol == 6 && bingoHad == false)
                {
                    bingoHad = true;
                    WinPopup.showWin = true;
                }
            }
        }
    }   //

    void SetupBoard(){
        bingoTable.GetComponent<GridLayoutGroup>().constraintCount = size;  //move board based on size
        if(size == 4){
            Vector3 tempVect = new Vector3(20, 0, 0);
            bingoTableTransform.position = canvasTransform.position + tempVect;
        }else if (size == 6){
            Vector3 tempVect = new Vector3(-23, 40, 0);
            bingoTableTransform.position = canvasTransform.position + tempVect;
        }

        //put 0-99 on a list
        for (int i = 0; i <= 99; i++)
        {
            RefNumbers.Add(i);
        }

        //select numButtons numbers.
        //choose 0-99, then compare to refnumbers
        //if it is on refnumbers, compare with environment and difficulty
        //based on that, maybe retry with a new number
        //otherwise, add it and set that number on refnumbers to -1, so you dont re-pick it
        for (int i = 0; i < numButtons; i++)
        {
            bool retry = true;
            int RandomNumA;
            int RandomNumB = 0;
            while(retry){                                   //go until you get a valid number
                RandomNumA = Random.Range(0, 99);
                if(RefNumbers[RandomNumA] == RandomNumA){   //prevents repeat numbers
                    retry = false;
                    if(environment == 0){                           //urban
                        if(tilesArr[RandomNumA].diffUrban == 0){    //if diff = 0, reroll
                            retry = true;
                        }else if (difficulty == 0){
                            RandomNumB = Random.Range(1, 7);       //on easy, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffUrban * 2;
                            if(RandomNumB < 7){                    //if total is < 7, restart
                                retry = true;
                            }
                        }else if (difficulty == 2){
                            RandomNumB = Random.Range(1, 7);       //on hard, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffUrban * 2;
                            if(RandomNumB > 7){                    //if total is > 7, restart
                                retry = true;
                            }
                        }
                    }else if(environment == 1){                     //plains
                        if(tilesArr[RandomNumA].diffPlains == 0){    //if diff = 0, reroll
                            retry = true;
                        }else if (difficulty == 0){
                            RandomNumB = Random.Range(1, 7);       //on easy, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffPlains * 2;
                            if(RandomNumB < 7){                    //if total is < 7, restart
                                retry = true;
                            }
                        }else if (difficulty == 2){
                            RandomNumB = Random.Range(1, 7);       //on hard, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffPlains * 2;
                            if(RandomNumB > 7){                    //if total is > 7, restart
                                retry = true;
                            }
                        }
                    }else if(environment == 2){                     //forest
                        if(tilesArr[RandomNumA].diffForest == 0){    //if diff = 0, reroll
                            retry = true;
                        }else if (difficulty == 0){
                            RandomNumB = Random.Range(1, 7);       //on easy, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffForest * 2;
                            if(RandomNumB < 7){                    //if total is < 7, restart
                                retry = true;
                            }
                        }else if (difficulty == 2){
                            RandomNumB = Random.Range(1, 7);       //on hard, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffForest * 2;
                            if(RandomNumB > 7){                    //if total is > 7, restart
                                retry = true;
                            }
                        }
                    }else if(environment == 3){                     //desert
                        if(tilesArr[RandomNumA].diffDesert == 0){    //if diff = 0, reroll
                            retry = true;
                        }else if (difficulty == 0){
                            RandomNumB = Random.Range(1, 7);       //on easy, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffDesert * 2;
                            if(RandomNumB < 7){                    //if total is < 7, restart
                                retry = true;
                            }
                        }else if (difficulty == 2){
                            RandomNumB = Random.Range(1, 7);       //on hard, roll 1 through 7 and add (environmental diff * 2)
                            RandomNumB += tilesArr[RandomNumA].diffDesert * 2;
                            if(RandomNumB > 7){                    //if total is > 7, restart
                                retry = true;
                            }
                        }
                    }
                } 

                if(retry == false){             //if you made it here and retry = false, add the number to the list
                    Numbers.Add(RandomNumA);
                    RefNumbers[RandomNumA] = -1;
                }
            }
        }

        //put images on corresponding buttons based on list
        for (int i = 0; i < numButtons; i++)
        {
            spriteObj[i].gameObject.transform.GetChild(0).GetComponent<Image>().sprite = tileSprites[Numbers[i]];
            spriteObj[i].gameObject.transform.GetChild(1).GetComponent<Image>().sprite = markerSprites[0];
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

    void SetupTiles(){
        for(int i = 0; i<=99; i++) {
            tiles tempTile = new tiles();
            tilesArr[i] = tempTile;
        }

        //setup tile names and difficulty
        //Bag
        tilesArr[0].diffUrban = 3;
        tilesArr[0].diffPlains = 1;
        tilesArr[0].diffForest = 1;
        tilesArr[0].diffDesert = 1;

        //Ball
        tilesArr[1].diffUrban = 2;

        //Bench
        tilesArr[2].diffUrban = 3;
        tilesArr[2].diffPlains = 1;
        tilesArr[2].diffForest = 1;
        tilesArr[2].diffDesert = 1;

        //Billboard with Food
        tilesArr[3].diffUrban = 3;
        tilesArr[3].diffPlains = 1;
        tilesArr[3].diffForest = 1;
        tilesArr[3].diffDesert = 1;

        //Billboard with a Person
        tilesArr[4].diffUrban = 3;
        tilesArr[4].diffPlains = 1;
        tilesArr[4].diffForest = 1;
        tilesArr[4].diffDesert = 1;

        //Billboard with Phone Number
        tilesArr[5].diffUrban = 3;
        tilesArr[5].diffPlains = 1;
        tilesArr[5].diffForest = 1;
        tilesArr[5].diffDesert = 1;

        //Bird of Prey
        tilesArr[6].diffPlains = 1;
        tilesArr[6].diffForest = 1;
        tilesArr[6].diffDesert = 1;

        //Blue Vehicle
        tilesArr[7].diffUrban = 3;
        tilesArr[7].diffPlains = 2;
        tilesArr[7].diffForest = 2;
        tilesArr[7].diffDesert = 2;

        //Boat
        tilesArr[8].diffUrban = 1;
        tilesArr[8].diffPlains = 1;
        tilesArr[8].diffForest = 1;
        tilesArr[8].diffDesert = 1;

        //Body of Water
        tilesArr[9].diffUrban = 1;
        tilesArr[9].diffPlains = 1;
        tilesArr[9].diffForest = 1;

        //Bridge
        tilesArr[10].diffUrban = 1;
        tilesArr[10].diffPlains = 1;
        tilesArr[10].diffForest = 1;
        tilesArr[10].diffDesert = 1;

        //Cactus
        tilesArr[11].diffDesert = 3;

        //Caution Stripes
        tilesArr[12].diffUrban = 2;
        tilesArr[12].diffPlains = 2;
        tilesArr[12].diffForest = 2;
        tilesArr[12].diffDesert = 2;

        //Chain Link Fence
        tilesArr[13].diffUrban = 3;
        tilesArr[13].diffPlains = 2;
        tilesArr[13].diffForest = 2;
        tilesArr[13].diffDesert = 2;

        //Cigarette
        tilesArr[14].diffUrban = 2;
        tilesArr[14].diffPlains = 1;
        tilesArr[14].diffForest = 1;
        tilesArr[14].diffDesert = 1;

        //Deer
        tilesArr[15].diffForest = 1;

        //Dirt Road
        tilesArr[16].diffUrban = 2;
        tilesArr[16].diffPlains = 3;
        tilesArr[16].diffForest = 2;
        tilesArr[16].diffDesert = 3;

        //Dog
        tilesArr[17].diffUrban = 2;
        tilesArr[17].diffPlains = 1;
        tilesArr[17].diffForest = 1;
        tilesArr[17].diffDesert = 1;

        //Fallen Log
        tilesArr[18].diffPlains = 2;
        tilesArr[18].diffForest = 3;
        tilesArr[18].diffDesert = 1;

        //Farm Vehicle
        tilesArr[19].diffPlains = 2;
        tilesArr[19].diffDesert = 1;

        //Fire Escape
        tilesArr[20].diffUrban = 3;

        //Firetruck
        tilesArr[21].diffUrban = 1;
        tilesArr[21].diffPlains = 1;
        tilesArr[21].diffForest = 1;
        tilesArr[21].diffDesert = 1;

        //Flag
        tilesArr[22].diffUrban = 3;
        tilesArr[22].diffPlains = 3;
        tilesArr[22].diffForest = 3;
        tilesArr[22].diffDesert = 3;

        //Graffiti
        tilesArr[23].diffUrban = 3;
        tilesArr[23].diffPlains = 2;
        tilesArr[23].diffForest = 2;
        tilesArr[23].diffDesert = 2;

        //Green Vehicle
        tilesArr[23].diffUrban = 2;
        tilesArr[23].diffPlains = 1;
        tilesArr[23].diffForest = 1;
        tilesArr[23].diffDesert = 1;

        //Hard Hat
        tilesArr[25].diffUrban = 2;
        tilesArr[25].diffPlains = 1;
        tilesArr[25].diffForest = 1;
        tilesArr[25].diffDesert = 1;

        //Jeep
        tilesArr[26].diffUrban = 3;
        tilesArr[26].diffPlains = 2;
        tilesArr[26].diffForest = 2;
        tilesArr[26].diffDesert = 2;

        //Ladder
        tilesArr[27].diffUrban = 3;
        tilesArr[27].diffPlains = 2;
        tilesArr[27].diffForest = 2;
        tilesArr[27].diffDesert = 2;

        //Litter
        tilesArr[28].diffUrban = 3;
        tilesArr[28].diffPlains = 3;
        tilesArr[28].diffForest = 3;
        tilesArr[28].diffDesert = 3;

        //Mile Marker
        tilesArr[29].diffUrban = 3;
        tilesArr[29].diffPlains = 3;
        tilesArr[29].diffForest = 3;
        tilesArr[29].diffDesert = 3;

        //Mobile Home
        tilesArr[30].diffUrban = 1;
        tilesArr[30].diffPlains = 1;
        tilesArr[30].diffForest = 1;
        tilesArr[30].diffDesert = 1;

        //No Parking Zone
        tilesArr[31].diffUrban = 3;
        tilesArr[31].diffPlains = 1;
        tilesArr[31].diffForest = 1;
        tilesArr[31].diffDesert = 1;

        //Pickett Fence
        tilesArr[32].diffUrban = 2;
        tilesArr[32].diffPlains = 1;
        tilesArr[32].diffForest = 1;
        tilesArr[32].diffDesert = 1;

        //Pickup Truck
        tilesArr[33].diffUrban = 3;
        tilesArr[33].diffPlains = 3;
        tilesArr[33].diffForest = 3;
        tilesArr[33].diffDesert = 3;

        //Ranch Fence
        tilesArr[34].diffUrban = 1;
        tilesArr[34].diffPlains = 3;
        tilesArr[34].diffForest = 2;
        tilesArr[34].diffDesert = 2;

        //Recycling Symbol
        tilesArr[35].diffUrban = 3;
        tilesArr[35].diffPlains = 1;
        tilesArr[35].diffForest = 1;
        tilesArr[35].diffDesert = 1;

        //Red Vehicle
        tilesArr[36].diffUrban = 3;
        tilesArr[36].diffPlains = 3;
        tilesArr[36].diffForest = 3;
        tilesArr[36].diffDesert = 3;

        //roadkill
        tilesArr[37].diffUrban = 1;
        tilesArr[37].diffPlains = 1;
        tilesArr[37].diffForest = 1;
        tilesArr[37].diffDesert = 1;

        //Railroad Tracks
        tilesArr[38].diffUrban = 2;
        tilesArr[38].diffPlains = 1;
        tilesArr[38].diffForest = 1;
        tilesArr[38].diffDesert = 1;

        //Smoke
        tilesArr[39].diffUrban = 2;
        tilesArr[39].diffPlains = 2;
        tilesArr[39].diffForest = 2;
        tilesArr[39].diffDesert = 2;

        //Statue
        tilesArr[40].diffUrban = 2;
        tilesArr[40].diffPlains = 1;
        tilesArr[40].diffForest = 1;
        tilesArr[40].diffDesert = 1;

        //Stop Sign
        tilesArr[41].diffUrban = 3;
        tilesArr[41].diffPlains = 3;
        tilesArr[41].diffForest = 3;
        tilesArr[41].diffDesert = 3;

        //Street Gutter
        tilesArr[42].diffUrban = 3;

        //Stump
        tilesArr[43].diffPlains = 2;
        tilesArr[43].diffForest = 2;
        tilesArr[43].diffDesert = 1;

        //Sunglasses
        tilesArr[44].diffUrban = 3;
        tilesArr[44].diffPlains = 1;
        tilesArr[44].diffForest = 1;
        tilesArr[44].diffDesert = 1;

        //Building with 3+ Floors
        tilesArr[45].diffUrban = 3;
        tilesArr[45].diffPlains = 1;
        tilesArr[45].diffForest = 1;
        tilesArr[45].diffDesert = 1;

        //Traffic Cone
        tilesArr[46].diffUrban = 2;
        tilesArr[46].diffPlains = 2;
        tilesArr[46].diffForest = 2;
        tilesArr[46].diffDesert = 2;

        //Trailer
        tilesArr[47].diffUrban = 2;
        tilesArr[47].diffPlains = 2;
        tilesArr[47].diffForest = 2;
        tilesArr[47].diffDesert = 2;

        //Wildflowers
        tilesArr[48].diffUrban = 2;
        tilesArr[48].diffPlains = 2;
        tilesArr[48].diffForest = 3;
        tilesArr[48].diffDesert = 2;

        //Yellow Vehicle
        tilesArr[49].diffUrban = 2;
        tilesArr[49].diffPlains = 1;
        tilesArr[49].diffForest = 1;
        tilesArr[49].diffDesert = 1;

        //Yield Sign
        tilesArr[50].diffUrban = 3;
        tilesArr[50].diffPlains = 2;
        tilesArr[50].diffForest = 2;
        tilesArr[50].diffDesert = 2;

        //atm
        tilesArr[51].diffUrban = 2;
        tilesArr[51].diffPlains = 1;
        tilesArr[51].diffForest = 1;
        tilesArr[51].diffDesert = 1;

        //bare tree
        tilesArr[52].diffUrban = 1;
        tilesArr[52].diffPlains = 2;
        tilesArr[52].diffForest = 3;
        tilesArr[52].diffDesert = 1;

        //beard
        tilesArr[53].diffUrban = 3;
        tilesArr[53].diffPlains = 2;
        tilesArr[53].diffForest = 2;
        tilesArr[53].diffDesert = 2;

        //bicycle
        tilesArr[54].diffUrban = 2;
        tilesArr[54].diffPlains = 1;
        tilesArr[54].diffForest = 1;
        tilesArr[54].diffDesert = 1;

        //bus
        tilesArr[55].diffUrban = 3;
        tilesArr[55].diffPlains = 1;
        tilesArr[55].diffForest = 1;
        tilesArr[55].diffDesert = 1;

        //bus stop
        tilesArr[56].diffUrban = 3;

        //clearance sign
        tilesArr[57].diffUrban = 3;
        tilesArr[57].diffPlains = 1;
        tilesArr[57].diffForest = 1;
        tilesArr[57].diffDesert = 1;

        //construction vehicle
        tilesArr[58].diffUrban = 2;
        tilesArr[58].diffPlains = 2;
        tilesArr[58].diffForest = 2;
        tilesArr[58].diffDesert = 2;

        //cow
        tilesArr[59].diffPlains = 2;

        //cross
        tilesArr[60].diffUrban = 2;
        tilesArr[60].diffPlains = 1;
        tilesArr[60].diffForest = 1;
        tilesArr[60].diffDesert = 1;

        //dirt_pile
        tilesArr[61].diffUrban = 2;
        tilesArr[61].diffPlains = 2;
        tilesArr[61].diffForest = 2;
        tilesArr[61].diffDesert = 2;

        //dont enter sign
        tilesArr[62].diffUrban = 3;
        tilesArr[62].diffPlains = 2;
        tilesArr[62].diffForest = 2;
        tilesArr[62].diffDesert = 2;

        //dumpster
        tilesArr[63].diffUrban = 3;
        tilesArr[63].diffPlains = 2;
        tilesArr[63].diffForest = 2;
        tilesArr[63].diffDesert = 2;

        //eight
        tilesArr[64].diffUrban = 3;
        tilesArr[64].diffPlains = 3;
        tilesArr[64].diffForest = 3;
        tilesArr[64].diffDesert = 3;

        //five
        tilesArr[65].diffUrban = 3;
        tilesArr[65].diffPlains = 3;
        tilesArr[65].diffForest = 3;
        tilesArr[65].diffDesert = 3;

        //four
        tilesArr[66].diffUrban = 3;
        tilesArr[66].diffPlains = 3;
        tilesArr[66].diffForest = 3;
        tilesArr[66].diffDesert = 3;

        //gravestone
        tilesArr[67].diffUrban = 1;
        tilesArr[67].diffPlains = 1;
        tilesArr[67].diffForest = 1;
        tilesArr[67].diffDesert = 1;

        //hat
        tilesArr[68].diffUrban = 3;
        tilesArr[68].diffPlains = 2;
        tilesArr[68].diffForest = 2;
        tilesArr[68].diffDesert = 2;

        //hay bale
        tilesArr[69].diffPlains = 2;

        //lightpost
        tilesArr[70].diffUrban = 3;
        tilesArr[70].diffPlains = 2;
        tilesArr[70].diffForest = 2;
        tilesArr[70].diffDesert = 2;

        //motorbike
        tilesArr[71].diffUrban = 3;
        tilesArr[71].diffPlains = 2;
        tilesArr[71].diffForest = 2;
        tilesArr[71].diffDesert = 2;

        //nine
        tilesArr[72].diffUrban = 3;
        tilesArr[72].diffPlains = 3;
        tilesArr[72].diffForest = 3;
        tilesArr[72].diffDesert = 3;

        //no tresspass sign
        tilesArr[73].diffUrban = 2;
        tilesArr[73].diffPlains = 3;
        tilesArr[73].diffForest = 3;
        tilesArr[73].diffDesert = 3;

        //oil tanker
        tilesArr[74].diffUrban = 1;
        tilesArr[74].diffPlains = 1;
        tilesArr[74].diffForest = 1;
        tilesArr[74].diffDesert = 1;

        //one
        tilesArr[75].diffUrban = 3;
        tilesArr[75].diffPlains = 3;
        tilesArr[75].diffForest = 3;
        tilesArr[75].diffDesert = 3;

        //out of state plate
        tilesArr[76].diffUrban = 3;
        tilesArr[76].diffPlains = 3;
        tilesArr[76].diffForest = 3;
        tilesArr[76].diffDesert = 3;

        //overpass
        tilesArr[77].diffUrban = 3;
        tilesArr[77].diffPlains = 1;
        tilesArr[77].diffForest = 1;
        tilesArr[77].diffDesert = 1;

        //phone lines
        tilesArr[78].diffUrban = 3;
        tilesArr[78].diffPlains = 3;
        tilesArr[78].diffForest = 3;
        tilesArr[78].diffDesert = 3;

        //plane
        tilesArr[79].diffUrban = 2;
        tilesArr[79].diffPlains = 2;
        tilesArr[79].diffForest = 2;
        tilesArr[79].diffDesert = 2;

        //police
        tilesArr[80].diffUrban = 2;
        tilesArr[80].diffPlains = 2;
        tilesArr[80].diffForest = 2;
        tilesArr[80].diffDesert = 2;

        //porta potty
        tilesArr[81].diffUrban = 2;
        tilesArr[81].diffPlains = 2;
        tilesArr[81].diffForest = 2;
        tilesArr[81].diffDesert = 2;

        //potted plant
        tilesArr[82].diffUrban = 3;
        tilesArr[82].diffPlains = 1;
        tilesArr[82].diffForest = 1;
        tilesArr[82].diffDesert = 1;

        //power lines
        tilesArr[83].diffUrban = 1;
        tilesArr[83].diffPlains = 2;
        tilesArr[83].diffForest = 1;
        tilesArr[83].diffDesert = 2;

        //satellite
        tilesArr[84].diffUrban = 3;
        tilesArr[84].diffPlains = 1;
        tilesArr[84].diffForest = 1;
        tilesArr[84].diffDesert = 1;

        //seven
        tilesArr[85].diffUrban = 3;
        tilesArr[85].diffPlains = 3;
        tilesArr[85].diffForest = 3;
        tilesArr[85].diffDesert = 3;

        //silo
        tilesArr[86].diffUrban = 1;
        tilesArr[86].diffPlains = 1;
        tilesArr[86].diffDesert = 1;

        //six
        tilesArr[87].diffUrban = 3;
        tilesArr[87].diffPlains = 3;
        tilesArr[87].diffForest = 3;
        tilesArr[87].diffDesert = 3;

        //solar panel
        tilesArr[88].diffUrban = 2;
        tilesArr[88].diffPlains = 1;
        tilesArr[88].diffForest = 1;
        tilesArr[88].diffDesert = 1;

        //star
        tilesArr[89].diffUrban = 3;
        tilesArr[89].diffPlains = 3;
        tilesArr[89].diffForest = 3;
        tilesArr[89].diffDesert = 3;

        //three
        tilesArr[90].diffUrban = 3;
        tilesArr[90].diffPlains = 3;
        tilesArr[90].diffForest = 3;
        tilesArr[90].diffDesert = 3;

        //two
        tilesArr[91].diffUrban = 3;
        tilesArr[91].diffPlains = 3;
        tilesArr[91].diffForest = 3;
        tilesArr[91].diffDesert = 3;

        //uturn sign
        tilesArr[92].diffUrban = 2;
        tilesArr[92].diffPlains = 2;
        tilesArr[92].diffForest = 2;
        tilesArr[92].diffDesert = 2;

        //vanity plate
        tilesArr[93].diffUrban = 1;
        tilesArr[93].diffPlains = 1;
        tilesArr[93].diffForest = 1;
        tilesArr[93].diffDesert = 1;

        //vine
        tilesArr[94].diffUrban = 1;
        tilesArr[94].diffPlains = 2;
        tilesArr[94].diffForest = 3;

        //water tower
        tilesArr[95].diffUrban = 3;
        tilesArr[95].diffPlains = 2;
        tilesArr[95].diffForest = 1;
        tilesArr[95].diffDesert = 2;

        //waterflow
        tilesArr[96].diffUrban = 1;
        tilesArr[96].diffPlains = 2;
        tilesArr[96].diffForest = 2;

        //work zone sign
        tilesArr[97].diffUrban = 2;
        tilesArr[97].diffPlains = 1;
        tilesArr[97].diffForest = 1;
        tilesArr[97].diffDesert = 1;

        //zero
        tilesArr[98].diffUrban = 3;
        tilesArr[98].diffPlains = 3;
        tilesArr[98].diffForest = 3;
        tilesArr[98].diffDesert = 3;

        //crop fields
        tilesArr[99].diffPlains = 2;
    }
}