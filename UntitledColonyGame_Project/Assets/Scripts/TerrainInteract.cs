using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// DEPRECIATED CLASS - USED AS REFERENCE FOR BUILDING TERRAIN INTERACT MNGR

public class TerrainInteract : MonoBehaviour
{ 
    //public GameObject UIElementPrefab;
    //public GameObject UIElement;

    //private bool clicked;
    //private bool clickAble = true;
    //Terrain terrain;

    //private void Awake()
    //{
    //    terrain = GetComponent<Terrain>();

    //}
    //private void Update()
    //{
    //    if (clicked)
    //    {
    //        Destroy(GameObject.FindWithTag("TempUI0"));
    //        UIElement = Instantiate(UIElementPrefab);


    //        Debug.Log(terrain.terrainType + " is selected and has " + terrain.reserve + " " + terrain.resourceType + " left.");
    //        UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Label>("TypeDisp").text += terrain.terrainType;
    //        UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Label>("ReserveDisp").text += terrain.reserve.ToString() + " " + terrain.resourceType;
    //        if (terrain.building != null)
    //            UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Label>("BuildingDisp").text += terrain.building.buildingType;
    //        else
    //            UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Label>("BuildingDisp").text += "None";
    //        if (terrain.building != null)
    //        {
    //            UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Button>("ConHouse").visible = false;
    //        }
    //        UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Button>("ConHouse").clickable.clicked += () =>
    //        {
    //            Debug.Log("House Constructed!");
    //            terrain.AddBuilding("House");
    //        };

    //    }
    //    clicked = false;
    //}
    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0) && clickAble)
    //    {
    //        Vector3 mousePos;
    //        mousePos = Input.mousePosition;
    //        mousePos = Camera.main.ScreenToViewportPoint(mousePos);

    //        clicked = true;
    //        clickAble = false;
    //    }
    //}

    //private void OnMouseUp()
    //{
    //    clicked = false;
    //    clickAble = true;
    //}
}
