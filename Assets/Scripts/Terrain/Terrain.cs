using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Terrain : MonoBehaviour
{
    //Collision Parameters
    public ContactFilter2D contactFilter;
    private BoxCollider2D boxCollider;


    //Data
    public string terrainType;
    public string resourceType;
    public int reserve;
    public Building building;

    public bool revealed;

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        revealed = false;   
    }

    public void AddBuilding(string type)
    {
        Debug.Log("Constructing building in terrain class!");
        building = new Building(type);
    }

    protected virtual void RoundUpdate()
    {
        //subtract building gen rate from reserve 
        //determine if event occurs
    }

    protected virtual void Event()
    {

    }

   
}
