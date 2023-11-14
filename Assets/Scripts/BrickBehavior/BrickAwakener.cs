using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickAwakener : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    //edit this value to define the score the totalScore needs to reach before the other spawners activate
    public int scoreForAwaken = 30;

   //assign this to an empty that has x number of spawners under it
    // Update is called once per frame
    void Update()
    {
        //checking if score gets to 30
        //for loop that awakens all children of object this is assigned too
        if (GameMgrScriptableObject.totalScore >= scoreForAwaken)//GameMgrScriptableObject.spawnProbability == 1)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameMgrScriptableObject.spawnProbability = 2;
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
