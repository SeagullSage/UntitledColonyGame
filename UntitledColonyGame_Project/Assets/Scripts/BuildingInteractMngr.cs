using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BuildingInteractMngr : MonoBehaviour
{
    public GameObject UIElementPrefab;
    public GameObject UIElement;
    public GameManager gameManager;

    [SerializeField]
    public Building building;
    public Terrain terrain;

    [SerializeField]
    VisualElement UIroot;

    public bool update;

    void Awake()
    {
        UIElement = Instantiate(UIElementPrefab);
        UIroot = UIElement.GetComponent<UIDocument>().rootVisualElement;
        //UIroot.transform.scale = Vector3.zero;
        update = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (update)
        {
            //do updates
            UpdateUI();
        }
        
    }

    void UpdateUI()
    {
        UIroot.Q<Label>("BuildingType").text = "" + building.buildingType;
        UIroot.Q<Label>("ProductionRate").text = "Production Rate: " + building.prodRate.ToString() + " " + terrain.resourceType;
        UIroot.Q<Label>("Population").text = "Population" + building.population;
        update = false;
    }
}
