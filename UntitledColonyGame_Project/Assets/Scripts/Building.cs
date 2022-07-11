using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building 
{
    // Virtual parent class for all building class scripts
    // No need for collision parameters, interfaced only with terrainInteract

    // Data
        // Identity
    public string buildingType;
        // Production
    public float prodScale;
    public int prodRate;
    // Array of current buff effects (water wheel, etc). Think of BTD6 buff system. ((If we dont come up with more, I guess make this a bool that applies +prodScale.


    // Construct,Research, Demolish : These arrays give costs related to construction and upgrading so that they are available to the user
    // in Terraininteract before instatiation of the building. Other arrays then store info on reseach demo that later get instatiated
    // on creating of the building, again to be accessed/displayed in TerrainInteract

        // To be given values in header

    public bool canMultiple;                            // Can multiple of these buildings be placed?
    public int[] constructCost = new int[] {0,0,0,0,0};   // Cost of each resource to build (gold,wood,stone,food,special) We might instead do this in GameManager
   
        // To be set in Awake/Start function (if it actually matters)

    public int[] salvageAmount;                         // Salvage amount when building is demolished (gold,wood,stone,food)

            // For research, array traverses down shared path and then each path sequentially. 2D does same but 
            // for each upgrade there is different associated resource costs (gold,wood,stone,food,special) ((special could be militia, morale, etc.))

    public int[] researchKnowCost;
    public int[][] researchResCost;

    public Terrain terrain;


    // Start is called before the first frame update
    public Building(string type)
    {
        Debug.Log(type + " is being constructing in building class");
        salvageAmount = new int[] {0,0,0,0,0};   
        buildingType = type;
        
    }

    //Performs any non-generation-of-main-resource based round actions; called from terrain
    protected virtual void RoundAction()
    {

    }
}
