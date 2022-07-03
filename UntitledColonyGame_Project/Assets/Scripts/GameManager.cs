using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* README: This script is what runs each "match" in the game. Not to be confused with *eventually* SceneManager, which will handle menu screens and *progress saving*. 
 * The script is responsible for the following actions:
    * Managing all resources
    * Track victory conditions and limits on time
    * Each round, visiting each terrain and calling associated terrain and building RoundUpdate functions
    * Tracking unlocked tiles, buildings, research
    * Tracking when a turn is completed based on user input
    * 
 */

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
