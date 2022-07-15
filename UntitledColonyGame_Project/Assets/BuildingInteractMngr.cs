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
    Building building;
    Terrain terrain;

    [SerializeField]
    VisualElement UIroot;

    bool update;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
