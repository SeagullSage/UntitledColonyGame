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
