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
    public tiles[] tilesArr = new tiles[51];
    public GameObject button00, bingoTable;
    public Transform bingoTableTransform, canvasTransform;
    public int numButtons;
    public bool newGame = true;

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
                    SceneManager.LoadSceneAsync("WinPopup");
                    bingoHad = true;
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
                    SceneManager.LoadSceneAsync("WinPopup");
                    bingoHad = true;
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
                    SceneManager.LoadSceneAsync("WinPopup");
                    bingoHad = true;
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

        //put 0-50 on a list
        for (int i = 0; i <= 50; i++)
        {
            RefNumbers.Add(i);
        }

        //select numButtons numbers.
        //choose 0-50, then compare to refnumbers
        //if it is on refnumbers, compare with environment and difficulty
        //based on that, maybe retry with a new number
        //otherwise, add it and set that number on refnumbers to -1, so you dont re-pick it
        for (int i = 0; i < numButtons; i++)
        {
            bool retry = true;
            int RandomNumA;
            int RandomNumB = 0;
            while(retry){                                   //go until you get a valid number
                RandomNumA = Random.Range(0, 50);
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
        for(int i = 0; i<=50; i++) {
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
    }
}