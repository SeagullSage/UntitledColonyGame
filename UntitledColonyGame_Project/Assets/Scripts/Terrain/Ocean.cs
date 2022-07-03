using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : Terrain
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        terrainType = "Ocean";
        resourceType = "Fish";
        reserve = Mathf.RoundToInt(Random.Range(85f, 135f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
