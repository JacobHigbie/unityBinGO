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
            case "atm": textObj.text = "ATM Machine"; break;
            case "bare_tree": textObj.text = "Bare Tree"; break;
            case "beard": textObj.text = "Beard"; break;
            case "bicycle": textObj.text = "Bicycle"; break;
            case "bus": textObj.text = "Bus"; break;
            case "bus_stop": textObj.text = "Bus Stop"; break;
            case "clearance_sign": textObj.text = "Low Clearance Sign"; break;
            case "construction_vehicle": textObj.text = "Construction Vehicle"; break;
            case "cow": textObj.text = "Cow"; break;
            case "crop_fields": textObj.text = "Crop Fields"; break;
            case "cross": textObj.text = "Cross"; break;
            case "dirt_pile": textObj.text = "Pile of Soil"; break;
            case "dont_enter_sign": textObj.text = "Do Not Enter Sign"; break;
            case "dumpster": textObj.text = "Dumpster"; break;
            case "eight": textObj.text = "The Number Eight"; break;
            case "five": textObj.text = "The Number Five"; break;
            case "four": textObj.text = "The Number Four"; break;
            case "gravestone": textObj.text = "Gravestone"; break;
            case "hat": textObj.text = "Any Hat"; break;
            case "hay_bale": textObj.text = "Hay Bale"; break;
            case "light_post": textObj.text = "Light Post"; break;
            case "motorbike": textObj.text = "Motorbike"; break;
            case "nine": textObj.text = "The Number Nine"; break;
            case "no_tresspass_sign": textObj.text = "Private Property Sign"; break;
            case "oil_tanker": textObj.text = "Tanker Trailer"; break;
            case "one": textObj.text = "The Number Eight"; break;
            case "out_of_state_plate": textObj.text = "Out of State Plate"; break;
            case "overpass": textObj.text = "Overpass"; break;
            case "phone_lines": textObj.text = "Phone Lines"; break;
            case "plane": textObj.text = "Any Aircraft"; break;
            case "police": textObj.text = "Police"; break;
            case "porta_potty": textObj.text = "Porta Potty"; break;
            case "potted_plant": textObj.text = "Potted Plant"; break;
            case "power_lines": textObj.text = "Power Lines"; break;
            case "satellite": textObj.text = "Satellite Dish"; break;
            case "seven": textObj.text = "The Number Seven"; break;
            case "silo": textObj.text = "Silo"; break;
            case "six": textObj.text = "The Number Six"; break;
            case "solar_panel": textObj.text = "Solar Panel"; break;
            case "star": textObj.text = "Star Shape"; break;
            case "three": textObj.text = "The Number Three"; break;
            case "two": textObj.text = "The Number Two"; break;
            case "uturn_sign": textObj.text = "U-Turn Sign"; break;
            case "vanity_plate": textObj.text = "Vanity Plate"; break;
            case "vine": textObj.text = "Vines"; break;
            case "water_tower": textObj.text = "Water Tower"; break;
            case "waterfall": textObj.text = "Flowing Water"; break;
            case "work_zone_sign": textObj.text = "Work Zone Sign"; break;
            case "zero": textObj.text = "The Number Zero"; break;
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
