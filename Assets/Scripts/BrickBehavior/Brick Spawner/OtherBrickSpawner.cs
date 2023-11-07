using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CenterSurrounder : MonoBehaviour
{
    public GameObject OriginalSurrounderObject;
    public float Radius;
    public int SurrounderObjectCount;
    private float angleStep;

    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;

    void Start()
    {
        //SurrounderParentTransform = new GameObject(gameObject.name + " Surrounder Parent").transform;
        SurrounderParentTransform = transform;
        // StartCoroutine(SurroundStepAnimated());
        SurroundStepAnimated();
    }
    
    // IEnumerator SurroundStepAnimated()
    // {
    //     yield return new WaitForSeconds(AppearWaitDuration);
    //
    //          angleStep  /= SurrounderObjectCount;
    //
    //     OriginalSurrounderObject.transform.SetParent(SurrounderParentTransform);
    //
    //     for (int i = 1; i < SurrounderObjectCount; i++)
    //     {
    //         GameObject newSurrounderObject = Instantiate(OriginalSurrounderObject);
    //
    //         newSurrounderObject.transform.RotateAround(transform.position, Vector3.up, angleStep * i);
    //         newSurrounderObject.transform.SetParent(SurrounderParentTransform);
    //
    //         yield return new WaitForSeconds(AppearWaitDuration);
    //     }
    //
    // }
    void SurroundStepAnimated()
    {
        for (int i = 0; i < SurrounderObjectCount; i++)
        {
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
            GameObject newSurrounderObject = Instantiate(OriginalSurrounderObject,pos,orientation,SurrounderParentTransform);
            
           // newSurrounderObject.transform.RotateAround(wrapDistance, Vector3.up, angleStep * i);

            
        }

    }
}
