using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    
    public House()
    {
        base.Start();
        buildingType = "House";
        population = 5;
    }
}

// Perhaps research will be managed with functions down below. Cost can be pulled from house to determine affordability and unlock
// pulled from gameManger and then brough into terrainInteract. Once deemed valid and purchased, functions here will carry out here?? Maybe a building interact
//function would be nice. 