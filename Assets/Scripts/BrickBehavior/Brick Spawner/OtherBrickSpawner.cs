using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class CenterSurrounder : MonoBehaviour
{
    public GameObject OriginalSurrounderObject;
    public float Radius;
    public int SurrounderObjectCount;
    private float angleStep;
    public GameObject brick;
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    
    private int spawnProbability;
    private GameObject empty;
    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;
  

    void Start()
    {
        spawnProbability = GameMgrScriptableObject.spawnProbability;
        empty = new GameObject();
        SurrounderParentTransform = transform;
        SurroundStepAnimated();
        
    }

    private void Update()
    {
       
    }

    // void SurroundStepAnimated()
    // {
    //     for (int i = 0; i < SurrounderObjectCount; i++)
    //     {
    //         float radius = Radius;
    //         //Getting percents from Amnt of Objects
    //         float percent = i / (float)SurrounderObjectCount;
    //         //remap to range 0->2pi.
    //         float x = percent * 2*Mathf.PI;
    //         //dir is position on unit circle
    //         Vector3 dir = new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)).normalized;
    //         //offseting 
    //         Vector3 pos = transform.position + dir*radius;
    //         //
    //         Quaternion orientation = Quaternion.LookRotation(-dir,Vector3.up);
    //         GameObject newSurrounderObject = Instantiate(OriginalSurrounderObject,pos,orientation,SurrounderParentTransform);
    //         
    //        // newSurrounderObject.transform.RotateAround(wrapDistance, Vector3.up, angleStep * i);
    //
    //         
    //     }
    //
    // }
    void SurroundStepAnimated()
    {
        for (int i = 0; i < SurrounderObjectCount; i++)
        {
            int spawnPick = Random.Range(0, spawnProbability);
            float radius = Radius;
            //Getting percents from Amnt of Objects
            float percent = i / (float)SurrounderObjectCount;
            //remap to range 0->2pi.
            float x = percent * 2*Mathf.PI;
            //dir is position on unit circle
            Vector3 dir = new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)).normalized;
            //offseting 
            Vector3 pos = transform.position + dir*radius;
            //
            Quaternion orientation = Quaternion.LookRotation(-dir,Vector3.up);
            if (spawnPick == 0)
            {
                Instantiate(brick,pos,orientation,SurrounderParentTransform);
            }
            else
            {
                Instantiate(empty,pos,orientation,SurrounderParentTransform);
            }
            
            // newSurrounderObject.transform.RotateAround(wrapDistance, Vector3.up, angleStep * i);
            
            
            
        }

    }
}
