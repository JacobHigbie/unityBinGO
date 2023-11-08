using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiles{
    public bool isChecked;
    public string objName;
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
    public int[] isMarked;
    public List<int> Numbers = new List<int>();
    public List<int> RefNumbers = new List<int>();
    public static int difficulty;
    public static int environment;
    public static int size;
    public bool bingoHad;
    public GameObject[] spriteObj;
    public tiles[] tilesArr = new tiles[51];


    // Start is called before the first frame update
    private void Start(){
        SetupTiles();
        SetupBoard();
        //bingoHad = false;
    }

    public void CheckWin(){
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

    void SetupBoard(){
        //put 0-50 on a list
        for (int i = 0; i <= 50; i++)
        {
            RefNumbers.Add(i);
        }

        //select 25 numbers.
        //choose 0-50, then compare to refnumbers
        //if it is on refnumbers, compare with environment and difficulty
        //based on that, maybe retry with a new number
        //otherwise, add it and set that number on refnumbers to -1, so you dont re-pick it
        for (int i = 0; i < 25; i++)
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
                }else{
                    Debug.Log("REROLL TRIGGERED:");
                    Debug.Log(tilesArr[RandomNumA].objName);
                    Debug.Log(RandomNumB);
                }
            }
        }

        //put images on corresponding buttons based on list
        for (int i = 0; i < 25; i++)
        {
            spriteObj[i].GetComponent<Image>().sprite = tileSprites[Numbers[i]];
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
            tilesArr[i].isChecked = false;
        }

        //setup tile names and difficulty
        tilesArr[0].objName = "Bag";
        tilesArr[0].diffUrban = 3;
        tilesArr[0].diffPlains = 1;
        tilesArr[0].diffForest = 1;
        tilesArr[0].diffDesert = 1;

        tilesArr[1].objName = "Ball";
        tilesArr[1].diffUrban = 2;

        tilesArr[2].objName = "Bench";
        tilesArr[2].diffUrban = 3;
        tilesArr[2].diffPlains = 1;
        tilesArr[2].diffForest = 1;
        tilesArr[2].diffDesert = 1;

        tilesArr[3].objName = "Billboard with Food";
        tilesArr[3].diffUrban = 3;
        tilesArr[3].diffPlains = 1;
        tilesArr[3].diffForest = 1;
        tilesArr[3].diffDesert = 1;

        tilesArr[4].objName = "Billboard with a Person";
        tilesArr[4].diffUrban = 3;
        tilesArr[4].diffPlains = 1;
        tilesArr[4].diffForest = 1;
        tilesArr[4].diffDesert = 1;

        tilesArr[5].objName = "Billboard with Phone Number";
        tilesArr[5].diffUrban = 3;
        tilesArr[5].diffPlains = 1;
        tilesArr[5].diffForest = 1;
        tilesArr[5].diffDesert = 1;

        tilesArr[6].objName = "Bird of Prey";
        tilesArr[6].diffPlains = 1;
        tilesArr[6].diffForest = 1;
        tilesArr[6].diffDesert = 1;

        tilesArr[7].objName = "Blue Vehicle";
        tilesArr[7].diffUrban = 3;
        tilesArr[7].diffPlains = 2;
        tilesArr[7].diffForest = 2;
        tilesArr[7].diffDesert = 2;

        tilesArr[8].objName = "Boat";
        tilesArr[8].diffUrban = 1;
        tilesArr[8].diffPlains = 1;
        tilesArr[8].diffForest = 1;
        tilesArr[8].diffDesert = 1;

        tilesArr[9].objName = "Body of Water";
        tilesArr[9].diffUrban = 1;
        tilesArr[9].diffPlains = 1;
        tilesArr[9].diffForest = 1;

        tilesArr[10].objName = "Bridge";
        tilesArr[10].diffUrban = 1;
        tilesArr[10].diffPlains = 1;
        tilesArr[10].diffForest = 1;
        tilesArr[10].diffDesert = 1;

        tilesArr[11].objName = "Cactus";
        tilesArr[11].diffDesert = 3;

        tilesArr[12].objName = "Caution Stripes";
        tilesArr[12].diffUrban = 2;
        tilesArr[12].diffPlains = 2;
        tilesArr[12].diffForest = 2;
        tilesArr[12].diffDesert = 2;

        tilesArr[13].objName = "Chain Link Fence";
        tilesArr[13].diffUrban = 3;
        tilesArr[13].diffPlains = 2;
        tilesArr[13].diffForest = 2;
        tilesArr[13].diffDesert = 2;

        tilesArr[14].objName = "Cigarette";
        tilesArr[14].diffUrban = 2;
        tilesArr[14].diffPlains = 1;
        tilesArr[14].diffForest = 1;
        tilesArr[14].diffDesert = 1;

        tilesArr[15].objName = "Deer";
        tilesArr[15].diffForest = 1;

        tilesArr[16].objName = "Dirt Road";
        tilesArr[16].diffUrban = 2;
        tilesArr[16].diffPlains = 3;
        tilesArr[16].diffForest = 2;
        tilesArr[16].diffDesert = 3;

        tilesArr[17].objName = "Dog";
        tilesArr[17].diffUrban = 2;
        tilesArr[17].diffPlains = 1;
        tilesArr[17].diffForest = 1;
        tilesArr[17].diffDesert = 1;

        tilesArr[18].objName = "Fallen Log";
        tilesArr[18].diffPlains = 2;
        tilesArr[18].diffForest = 3;
        tilesArr[18].diffDesert = 1;

        tilesArr[19].objName = "Farm Vehicle";
        tilesArr[19].diffPlains = 2;
        tilesArr[19].diffDesert = 1;

        tilesArr[20].objName = "Fire Escape";
        tilesArr[20].diffUrban = 3;

        tilesArr[21].objName = "Firetruck";
        tilesArr[21].diffUrban = 1;
        tilesArr[21].diffPlains = 1;
        tilesArr[21].diffForest = 1;
        tilesArr[21].diffDesert = 1;

        tilesArr[22].objName = "Flag";
        tilesArr[22].diffUrban = 3;
        tilesArr[22].diffPlains = 3;
        tilesArr[22].diffForest = 3;
        tilesArr[22].diffDesert = 3;

        tilesArr[23].objName = "Graffiti";
        tilesArr[23].diffUrban = 3;
        tilesArr[23].diffPlains = 2;
        tilesArr[23].diffForest = 2;
        tilesArr[23].diffDesert = 2;

        tilesArr[24].objName = "Green Vehicle";
        tilesArr[23].diffUrban = 2;
        tilesArr[23].diffPlains = 1;
        tilesArr[23].diffForest = 1;
        tilesArr[23].diffDesert = 1;

        tilesArr[25].objName = "Hard Hat";
        tilesArr[25].diffUrban = 2;
        tilesArr[25].diffPlains = 1;
        tilesArr[25].diffForest = 1;
        tilesArr[25].diffDesert = 1;

        tilesArr[26].objName = "Jeep";
        tilesArr[26].diffUrban = 3;
        tilesArr[26].diffPlains = 2;
        tilesArr[26].diffForest = 2;
        tilesArr[26].diffDesert = 2;

        tilesArr[27].objName = "Ladder";
        tilesArr[27].diffUrban = 3;
        tilesArr[27].diffPlains = 2;
        tilesArr[27].diffForest = 2;
        tilesArr[27].diffDesert = 2;

        tilesArr[28].objName = "Litter";
        tilesArr[28].diffUrban = 3;
        tilesArr[28].diffPlains = 3;
        tilesArr[28].diffForest = 3;
        tilesArr[28].diffDesert = 3;

        tilesArr[29].objName = "Mile Marker";
        tilesArr[29].diffUrban = 3;
        tilesArr[29].diffPlains = 3;
        tilesArr[29].diffForest = 3;
        tilesArr[29].diffDesert = 3;

        tilesArr[30].objName = "Mobile Home";
        tilesArr[30].diffUrban = 1;
        tilesArr[30].diffPlains = 1;
        tilesArr[30].diffForest = 1;
        tilesArr[30].diffDesert = 1;

        tilesArr[31].objName = "No Parking Zone";
        tilesArr[31].diffUrban = 3;
        tilesArr[31].diffPlains = 1;
        tilesArr[31].diffForest = 1;
        tilesArr[31].diffDesert = 1;

        tilesArr[32].objName = "Pickett Fence";
        tilesArr[32].diffUrban = 2;
        tilesArr[32].diffPlains = 1;
        tilesArr[32].diffForest = 1;
        tilesArr[32].diffDesert = 1;

        tilesArr[33].objName = "Pickup Truck";
        tilesArr[33].diffUrban = 3;
        tilesArr[33].diffPlains = 3;
        tilesArr[33].diffForest = 3;
        tilesArr[33].diffDesert = 3;

        tilesArr[34].objName = "Ranch Fence";
        tilesArr[34].diffUrban = 1;
        tilesArr[34].diffPlains = 3;
        tilesArr[34].diffForest = 2;
        tilesArr[34].diffDesert = 2;

        tilesArr[35].objName = "Recycling Symbol";
        tilesArr[35].diffUrban = 3;
        tilesArr[35].diffPlains = 1;
        tilesArr[35].diffForest = 1;
        tilesArr[35].diffDesert = 1;

        tilesArr[36].objName = "Red Vehicle";
        tilesArr[36].diffUrban = 3;
        tilesArr[36].diffPlains = 3;
        tilesArr[36].diffForest = 3;
        tilesArr[36].diffDesert = 3;

        tilesArr[37].objName = "Roadkill";
        tilesArr[37].diffUrban = 1;
        tilesArr[37].diffPlains = 1;
        tilesArr[37].diffForest = 1;
        tilesArr[37].diffDesert = 1;

        tilesArr[38].objName = "Railroad Tracks";
        tilesArr[38].diffUrban = 2;
        tilesArr[38].diffPlains = 1;
        tilesArr[38].diffForest = 1;
        tilesArr[38].diffDesert = 1;

        tilesArr[39].objName = "Smoke";
        tilesArr[39].diffUrban = 2;
        tilesArr[39].diffPlains = 2;
        tilesArr[39].diffForest = 2;
        tilesArr[39].diffDesert = 2;

        tilesArr[40].objName = "Statue";
        tilesArr[40].diffUrban = 2;
        tilesArr[40].diffPlains = 1;
        tilesArr[40].diffForest = 1;
        tilesArr[40].diffDesert = 1;

        tilesArr[41].objName = "Stop Sign";
        tilesArr[41].diffUrban = 3;
        tilesArr[41].diffPlains = 3;
        tilesArr[41].diffForest = 3;
        tilesArr[41].diffDesert = 3;

        tilesArr[42].objName = "Street Gutter";
        tilesArr[42].diffUrban = 3;

        tilesArr[43].objName = "Stump";
        tilesArr[43].diffPlains = 2;
        tilesArr[43].diffForest = 2;
        tilesArr[43].diffDesert = 1;

        tilesArr[44].objName = "Sunglasses";
        tilesArr[44].diffUrban = 3;
        tilesArr[44].diffPlains = 1;
        tilesArr[44].diffForest = 1;
        tilesArr[44].diffDesert = 1;

        tilesArr[45].objName = "Building with 3+ Floors";
        tilesArr[45].diffUrban = 3;
        tilesArr[45].diffPlains = 1;
        tilesArr[45].diffForest = 1;
        tilesArr[45].diffDesert = 1;

        tilesArr[46].objName = "Traffic Cone";
        tilesArr[46].diffUrban = 2;
        tilesArr[46].diffPlains = 2;
        tilesArr[46].diffForest = 2;
        tilesArr[46].diffDesert = 2;

        tilesArr[47].objName = "Trailer";
        tilesArr[47].diffUrban = 2;
        tilesArr[47].diffPlains = 2;
        tilesArr[47].diffForest = 2;
        tilesArr[47].diffDesert = 2;

        tilesArr[48].objName = "Wildflowers";
        tilesArr[48].diffUrban = 2;
        tilesArr[48].diffPlains = 2;
        tilesArr[48].diffForest = 3;
        tilesArr[48].diffDesert = 2;

        tilesArr[49].objName = "Yellow Vehicle";
        tilesArr[49].diffUrban = 2;
        tilesArr[49].diffPlains = 1;
        tilesArr[49].diffForest = 1;
        tilesArr[49].diffDesert = 1;

        tilesArr[50].objName = "Yield Sign";
        tilesArr[50].diffUrban = 3;
        tilesArr[50].diffPlains = 2;
        tilesArr[50].diffForest = 2;
        tilesArr[50].diffDesert = 2;
    }
}