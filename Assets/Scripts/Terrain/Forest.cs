using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Terrain
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        terrainType = "Forest";
        resourceType = "wood";
        reserve = Mathf.RoundToInt(Random.Range(90f, 120f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
