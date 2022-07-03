using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : Terrain
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        terrainType = "River";
        resourceType = "Fish";
        reserve = Mathf.RoundToInt(Random.Range(50f, 70f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
