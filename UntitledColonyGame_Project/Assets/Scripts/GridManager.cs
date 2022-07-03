using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float xStart, yStart;

    public int columnLength, rowLength;
    public float xSpace, ySpace;
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < columnLength * rowLength; i++)
        {
            Instantiate(prefab, new Vector3(xStart + (xSpace * (i % columnLength)),yStart +  (-ySpace * (i / columnLength))), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
