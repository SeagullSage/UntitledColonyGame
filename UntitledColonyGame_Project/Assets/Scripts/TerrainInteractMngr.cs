using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class TerrainInteractMngr : MonoBehaviour
{
    public GameObject UIElementPrefab;
    public GameObject UIElement;
    public GameManager gameManager;

    private bool clicked;
    private bool clickAble = true;
    [SerializeField]
    Terrain terrain;

    Vector3 mousePos;
    Vector2 mousePos2D;
    RaycastHit2D hit;

    [SerializeField]
    VisualElement UIroot;

    bool update;

    private void Awake()
    {
        UIElement = Instantiate(UIElementPrefab);
        Debug.Log(UIElement == null);
        UIroot = UIElement.GetComponent<UIDocument>().rootVisualElement;
        //UIroot.transform.scale = Vector3.zero;
        Debug.Log(UIroot.Q<Label>("TypeDisp").text);
        update = false;



    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckClick();

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Terrain")
                {
                    Debug.Log("terrain selected");
                    //UIroot.transform.scale = Vector3.one;
                    terrain = hit.collider.GetComponent<Terrain>();
                    update = true;
                }
            }
            else
            {
                //UIroot.transform.scale = Vector3.zero;
            }
        }

        UIElement.GetComponent<UIDocument>().rootVisualElement.Q<Button>("ConHouse").clickable.clicked += () =>
        {   
            // This is a temporary fix to the issue of constructing a TON
            // of houses when button is clicked. Look into better way to avoid multiple clicks per click
            if (terrain.building == null)  
            {
                // if (can afford)
                if (gameManager.wood >= gameManager.houseCost[1] && gameManager.food >= gameManager.houseCost[3])
                {
                    Debug.Log("House Constructed!");
                    terrain.AddBuilding("House");
                    gameManager.wood -= gameManager.houseCost[1];
                    gameManager.food -= gameManager.houseCost[3];
                    gameManager.pop += terrain.building.population;
                    update = true;
                }
                //else | This also prints like a gagillion times because of the multiple times per click error explained (and currently unresolved) above
                //{
                //    Debug.Log("Can't Afford!");
                //}
            }
        };

        if (update)
        {
            UpdateUI();
            update = false;
        }

    }

    private void CheckClick()
    {
        Debug.Log("Checking if terrain clicked");

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos2D = new Vector2(mousePos.x, mousePos.y);

        hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
    }

    private void UpdateUI()
    {
        UIroot.Q<Label>("TypeDisp").text = "Type: " + terrain.terrainType;
        UIroot.Q<Label>("ReserveDisp").text = "Reserve " + terrain.reserve.ToString() + " " + terrain.resourceType;
        if (terrain.building != null)
        {
            UIroot.Q<Label>("BuildingDisp").text = terrain.building.buildingType;
        }
        else
        {
            UIroot.Q<Label>("BuildingDisp").text = "No Building";
        }
    }

    private void ClearUI()
    {
        Debug.Log("clearing UI");
        UIroot.Q<Label>("TypeDisp").text = UIroot.Q<Label>("TypeDisp").text.Remove(UIroot.Q<Label>("TypeDisp").text.IndexOf(':') + 1);
        UIroot.Q<Label>("ReserveDisp").text = UIroot.Q<Label>("ReserveDisp").text.Remove(UIroot.Q<Label>("ReserveDisp").text.IndexOf(':') + 1);
        UIroot.Q<Label>("BuildingDisp").text = UIroot.Q<Label>("BuildingDisp").text.Remove(UIroot.Q<Label>("BuildingDisp").text.IndexOf(':') + 1);
    }
}
