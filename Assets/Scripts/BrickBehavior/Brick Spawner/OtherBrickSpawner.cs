using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class CenterSurrounder : MonoBehaviour
{
    //How far brick spawns from spawners
    public float Radius;
    //Max number of bricks that can spawn
    public int SurrounderObjectCount;
    //Put brick object here
    public GameObject brick;
    //Put Scriptable Object of game Manager here
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    
    private int spawnProbability;
    private GameObject empty;
    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;
    private bool brickSpawnerCoRoutineStarted;
  

    void Start()
    {
        //bool for checking to see if coroutine is running
        brickSpawnerCoRoutineStarted = true;
        //creates empty thats one of two things that the object spawns in
        empty = new GameObject();
        //setting anchor transform for rotation
        SurrounderParentTransform = transform;
        //SpawnBrick();
        
    }

    private void Update()
    {
        
        //This checks to see if the amount of bricks in the scene is zero, and if it is then brick coroutine spawns
        if ((GameMgrScriptableObject.startBricksInScene = GameObject.FindGameObjectsWithTag("Brick").Length) == 0)
        {
          
            if (brickSpawnerCoRoutineStarted == true)
            {
                StartCoroutine(SpawnBrickTimed());
                GameMgrScriptableObject.spawnProbability -= 1;
            }
           
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

    private IEnumerator SpawnBrickTimed()
    {
        brickSpawnerCoRoutineStarted = false;
        yield return new WaitForSeconds(1.0f);
            for (int i = 0; i < SurrounderObjectCount; i++)
            {
                //probability logic for brick spawning
                int spawnPick = Random.Range(0, GameMgrScriptableObject.spawnProbability);
                float radius = Radius;
                //Getting percents from Amnt of Objects
                float percent = i / (float)SurrounderObjectCount;
                //remap to range 0->2pi.
                float x = percent * 2 * Mathf.PI;
                //dir is position on unit circle
                Vector3 dir = new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)).normalized;
                //offseting 
                Vector3 pos = transform.position + dir * radius;
                //
                Quaternion orientation = Quaternion.LookRotation(-dir, Vector3.up);
                if (spawnPick == 0)
                {
                    Instantiate(brick, pos, orientation, SurrounderParentTransform);
                }
                else
                {
                    Instantiate(empty, pos, orientation, SurrounderParentTransform);
                }
            }
            yield return brickSpawnerCoRoutineStarted = true;
           
    }
}
