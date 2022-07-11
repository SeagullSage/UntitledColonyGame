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

    public int productionMod;

    public bool revealed;

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        revealed = false;   
    }

    public void AddBuilding(string type)
    {
        Debug.Log("Constructing building in terrain class!");
        switch (type)
        {
            case "House":
                building = new House();
                break;
            default:
                Debug.Log("BUILDING ERROR - NULL BUILDING");
                break;
        }
    }

    protected virtual void RoundUpdate()
    {
        //subtract building gen rate from reserve 
        //determine if event occurs
    }

    protected virtual void Event()
    {
        // Some terrain have specific events
            // Volcanos - Erruption
            // Swamps - Floods
        // Some events can occur on any terrain
            // Earthquake, Meteor
    }

   
}
