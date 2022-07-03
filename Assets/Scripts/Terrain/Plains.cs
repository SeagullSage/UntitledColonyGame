using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plains : Terrain
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        terrainType = "Plains";
        resourceType = "none";
        reserve = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
