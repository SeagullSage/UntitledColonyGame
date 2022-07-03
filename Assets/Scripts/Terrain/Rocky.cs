using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocky : Terrain
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        terrainType = "Rocky";
        resourceType = "Gold";
        reserve = Mathf.RoundToInt(Random.Range(70f, 115f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
