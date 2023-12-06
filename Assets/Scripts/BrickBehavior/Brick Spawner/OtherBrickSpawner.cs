using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class CenterSurrounder : MonoBehaviour
{
    //How far brick spawns from spawner
    public float Radius;
    //Max number of bricks that can spawn
    public int maxBrickCount;
    //Put brick object here
    public GameObject brick;
    //Put Scriptable Object of game Manager here
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    
    private int spawnProbability;
    public GameObject emtpyPrefab;
    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;
    private bool brickSpawnerCoRoutineStarted;
  

    void Start()
    {
        //bool for checking to see if coroutine is running
        brickSpawnerCoRoutineStarted = false;
        //creates empty thats one of two things that the object spawns in
        emtpyPrefab = new GameObject();
        //setting anchor transform for rotation
        SurrounderParentTransform = transform;
        //SpawnBrick();
        
    }

    private void Update()
    {
        
        //This checks to see if the amount of bricks in the scene is zero, and if it is then brick coroutine begins
        //This is level logic
        if ((GameMgrScriptableObject.startBricksInScene = GameObject.FindGameObjectsWithTag("Brick").Length) == 0)
        {
          
            if (!brickSpawnerCoRoutineStarted)
            {
                StartCoroutine(SpawnBrickTimed());
                GameMgrScriptableObject.spawnProbability -= 1;
            }

            if (GameMgrScriptableObject.spawnProbability <= 1)
            {
                GameMgrScriptableObject.spawnProbability = 10;
            }

        }
       
    }
   

    private IEnumerator SpawnBrickTimed()
    {
        brickSpawnerCoRoutineStarted = true;
        RoundValuesIncrease();
        yield return new WaitForSeconds(4.0f);
            for (int i = 0; i < maxBrickCount; i++)
            {
                //probability logic for brick spawning
                int spawnPick = Random.Range(0, GameMgrScriptableObject.spawnProbability);
                float radius = Radius;
                //Getting percents from Amnt of Objects
                float percent = i / (float)maxBrickCount;
                //remap to range 0->2pi.
                float x = percent * 2 * Mathf.PI;
                //dir is position on unit circle
                Vector3 dir = new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)).normalized;
                //offseting 
                Vector3 pos = transform.position + dir * radius;
                Quaternion orientation = Quaternion.LookRotation(-dir, Vector3.up);
                if (spawnPick == 0)
                {
                    Instantiate(brick, pos, orientation, SurrounderParentTransform);
                }
                else
                {
                    Instantiate(emtpyPrefab, pos, orientation, SurrounderParentTransform);
                }
            }
            yield return brickSpawnerCoRoutineStarted = false;
           
    }

    public void RoundValuesIncrease()
    {
        //Increasing Spawner Stuff
        //Increasing the spin with each round
        GameMgrScriptableObject.spawnerSpinSpeed += (GameMgrScriptableObject.spawnerSpinSpeed/2);
        //Increase Max Brick Count
        GameMgrScriptableObject.maxBrickCount += 4;
        
        //Affecting Ball Values w/ each round
        GameMgrScriptableObject.yAxisForce += (GameMgrScriptableObject.yAxisForce/8);
        GameMgrScriptableObject.bounceForce += (GameMgrScriptableObject.bounceForce / 2);
    }
  
}
// public void SpawnBrick()
// {
//         for (int i = 0; i < SurrounderObjectCount; i++)
//         {
//             int spawnPick = Random.Range(0, GameMgrScriptableObject.spawnProbability);
//             float radius = Radius;
//             //Getting percents from Amnt of Objects
//             float percent = i / (float)SurrounderObjectCount;
//             //remap to range 0->2pi.
//             float x = percent * 2 * Mathf.PI;
//             //dir is position on unit circle
//             Vector3 dir = new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)).normalized;
//             //offseting 
//             Vector3 pos = transform.position + dir * radius;
//             //
//             Quaternion orientation = Quaternion.LookRotation(-dir, Vector3.up);
//             if (spawnPick == 0)
//             {
//                 Instantiate(brick, pos, orientation, SurrounderParentTransform);
//             }
//             else
//             {
//                 Instantiate(empty, pos, orientation, SurrounderParentTransform);
//             }
//         }
// }