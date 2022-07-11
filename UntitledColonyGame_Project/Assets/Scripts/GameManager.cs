using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* README: This script is what runs each "match" in the game. Not to be confused with *eventually* SceneManager, which will handle menu screens and *progress saving*. 
 * The script is responsible for the following actions:
    * Managing all resources
    * Track victory conditions and limits on time
    * Each round, visiting each terrain and calling associated terrain and building RoundUpdate functions
    * Tracking unlocked tiles, buildings, research (Maybe tiles unlocked,total should be handled by whatever generates map)
    * Tracking when a turn is completed based on user input
    * 
 */

public class GameManager : MonoBehaviour
{
    // Resources
    public int gold;
    public int wood;
    public int stone;
    public int food;
    public int pop;
    public int militia;
    public int know;
    public int morale;

    // Colony Rates and Values

    public int taxRate;
    public int taxCollect;
    public int theifStrength;

    public float productionRate;
    public float disasterRate;

    // Game Tracking

    // Eventually for different civs, game modes, and difficulty settings. Largely for game intialization.
    public string gameMode;
    public string colonyType;
    public int gameDifficulty;

    public int round;
    public int roundLimit;
    public int landClaimed;
    public int landTotal;
    public int disasterTotal;

    // Keeps track of when user clicks to progress round, or does something (buy, build) that requires updating of resources/unlocks 
    public bool nextRound;
    public bool update;

    // Building and Research Unlock Track

    public int[] houseCost = new int[] {0,15,0,10,0,0,0,0};



    // Start is called before the first frame update
    void Start()
    {
        ResourcesSetUP();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResourcesSetUP()
    {
        round = 1;
        food = 100;
        gold = 75;
        wood = 100;
        stone = 100;
        pop = 50;
        militia = 0;
        know = 25;
        morale = 0;
    }
}
