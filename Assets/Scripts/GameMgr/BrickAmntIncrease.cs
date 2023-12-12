using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickAmntIncrease : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    private void Update()
    {
        if ((GameMgrScriptableObject.startBricksInScene = GameObject.FindGameObjectsWithTag("Brick").Length) == 0)
        {
            StartCoroutine(IncreaseValues());
        }
    }

    private IEnumerator IncreaseValues()
    {
        yield return new WaitForSeconds(4.0f);
        //Increasing Spawner Stuff
        //Increasing the spin with each round
        GameMgrScriptableObject.spawnerSpinSpeed += (GameMgrScriptableObject.spawnerSpinSpeed/2);
        //Increase Max Brick Count
        GameMgrScriptableObject.maxBrickCount += 1;
        
        //Affecting Ball Values w/ each round
        GameMgrScriptableObject.yAxisForce += (GameMgrScriptableObject.yAxisForce/10);
        GameMgrScriptableObject.bounceForce += (GameMgrScriptableObject.bounceForce / 4);
        yield return new WaitForSeconds(4.0f);
    }

    public void RoundValuesIncrease()
    {
        //Increasing Spawner Stuff
        //Increasing the spin with each round
        GameMgrScriptableObject.spawnerSpinSpeed += (GameMgrScriptableObject.spawnerSpinSpeed/2);
        //Increase Max Brick Count
        GameMgrScriptableObject.maxBrickCount += 1;
        
        //Affecting Ball Values w/ each round
        GameMgrScriptableObject.yAxisForce += (GameMgrScriptableObject.yAxisForce/10);
        GameMgrScriptableObject.bounceForce += (GameMgrScriptableObject.bounceForce / 4);
    }
}
