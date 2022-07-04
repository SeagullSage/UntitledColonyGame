using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResourceDisplayMngr : MonoBehaviour
{
    public GameObject UIElementPrefab;
    public GameObject UIElement;

    public GameManager gameManager;

    [SerializeField]
    VisualElement UIroot;

    bool update;


    // Start is called before the first frame update
    void Start()
    {
        UIElement = Instantiate(UIElementPrefab);
        UIroot = UIElement.GetComponent<UIDocument>().rootVisualElement;
        update = true;
    }

    // Instead of update, eventually do this based on events from clicked buttons via terraininteract mngr
    void Update()
    {
        if (update)
        {
            UpdateUI();
            //update = false;
        }

    }

    private void ClearUI()
    {
        UIroot.Q<Label>("RoundCnt").text = UIroot.Q<Label>("RoundCnt").text.Remove(UIroot.Q<Label>("RoundCnt").text.IndexOf(':') + 1);
        //UIroot.Q<Label>("ReserveDisp").text = UIroot.Q<Label>("ReserveDisp").text.Remove(UIroot.Q<Label>("ReserveDisp").text.IndexOf(':') + 1);
        //UIroot.Q<Label>("BuildingDisp").text = UIroot.Q<Label>("BuildingDisp").text.Remove(UIroot.Q<Label>("BuildingDisp").text.IndexOf(':') + 1);

    }

    private void UpdateUI()
    {
        //ClearUI();
        UIroot.Q<Label>("RoundCnt").text = "Round: " + gameManager.round;
        UIroot.Q<Label>("GoldCnt").text = "Gold: " + gameManager.gold;
        UIroot.Q<Label>("WoodCnt").text = "Wood: " + gameManager.wood;
        UIroot.Q<Label>("StoneCnt").text = "Stone: " + gameManager.stone;
        UIroot.Q<Label>("FoodCnt").text = "Food: " + gameManager.food;
        UIroot.Q<Label>("PopCnt").text = "Pop: " + gameManager.pop;
        UIroot.Q<Label>("MilCnt").text = "Militia: " + gameManager.militia;
        UIroot.Q<Label>("KnoCnt").text = "Knowledge: " + gameManager.know;
        UIroot.Q<Label>("MoraleCnt").text = "Morale: " + gameManager.morale;
    }
}
