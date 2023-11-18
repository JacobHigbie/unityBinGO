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
            //Debug.Log(spriteName);
            panelTransform.gameObject.SetActive(true);
            switch(spriteName){
            case "bag": textObj.text = "Any Bag"; break;
            case "ball": textObj.text = "Any Ball"; break;
            case "bench": textObj.text = "Bench"; break;
            case "billboard_food": textObj.text = "Billboard with Food"; break;
            case "billboard_man": textObj.text = "Billboard with a Person"; break;
            case "billboard_phone": textObj.text = "Billboard with a Phone Number"; break;
            case "bird_of_prey": textObj.text = "Any Bird of Prey"; break;
            case "blue_vehicle": textObj.text = "Any Blue Vehicle"; break;
            case "boat": textObj.text = "Any Water Vehicle"; break;
            case "body_of_water": textObj.text = "Natural Body of Water"; break;
            case "bridge": textObj.text = "Bridge"; break;
            case "cactus": textObj.text = "Cactus"; break;
            case "caution_stripes": textObj.text = "Caution Stripes"; break;
            case "chain_link_fence": textObj.text = "Chain Link Fence"; break;
            case "cigarette": textObj.text = "Cigarette"; break;
            case "deer": textObj.text = "Deer"; break;
            case "dirt_road": textObj.text = "Dirt Road"; break;
            case "dog": textObj.text = "Dog"; break;
            case "fallen_log": textObj.text = "Fallen Log"; break;
            case "farm_vehicle": textObj.text = "Any Farm Vehicle"; break;
            case "fire_escape": textObj.text = "Fire Escape"; break;
            case "firetruck": textObj.text = "Fire Truck"; break;
            case "flag": textObj.text = "Any Flag"; break;
            case "graffiti": textObj.text = "Grafitti"; break;
            case "green_vehicle": textObj.text = "Any Green Vehicle"; break;
            case "hard_hat": textObj.text = "Hard Hat"; break;
            case "jeep": textObj.text = "Jeep"; break;
            case "ladder": textObj.text = "Ladder"; break;
            case "litter": textObj.text = "Litter"; break;
            case "mile_marker": textObj.text = "Mile Marker"; break;
            case "mobile_home": textObj.text = "Mobile Home"; break;
            case "no_parking_zone": textObj.text = "No Parking Zone"; break;
            case "pickett_fence": textObj.text = "Pickett Fence"; break;
            case "pickup_truck": textObj.text = "Pickup Truck"; break;
            case "ranch_fence": textObj.text = "Ranch Fence"; break;
            case "recyling_logo": textObj.text = "Recycling Symbol"; break;
            case "red_vehicle": textObj.text = "Any Red Vehicle"; break;
            case "roadkill": textObj.text = "Roadkill"; break;
            case "rr_tracks": textObj.text = "Railroad Tracks"; break;
            case "smoke": textObj.text = "Smoke or Vapor"; break;
            case "statue": textObj.text = "Any Statue"; break;
            case "stop_sign": textObj.text = "Stop Sign"; break;
            case "street_gutter": textObj.text = "Street Gutter"; break;
            case "stump": textObj.text = "Tree Stump"; break;
            case "sunglasses": textObj.text = "Sunglasses"; break;
            case "three_stry_bldg": textObj.text = "Building with 3+ Floors"; break;
            case "traffic_cone": textObj.text = "Traffic Cone"; break;
            case "trailer": textObj.text = "Moving Trailer"; break;
            case "wildflowers": textObj.text = "Wildflowers"; break;
            case "yellow_vehicle": textObj.text = "Any Yellow Vehicle"; break;
            case "yield_sign": textObj.text = "Yield Sign"; break;
            default: textObj.text = "Missing Object Name"; break;
            }
        }
        else
        {
            if (bingoTableTransform.gameObject.GetComponent<generateTiles>().isMarked[buttonElementNumber] == 0){
                bingoTableTransform.gameObject.GetComponent<generateTiles>().isMarked[buttonElementNumber] = 1;
            }else{
                bingoTableTransform.gameObject.GetComponent<generateTiles>().isMarked[buttonElementNumber] = 0;
            }
        }
    }
}
