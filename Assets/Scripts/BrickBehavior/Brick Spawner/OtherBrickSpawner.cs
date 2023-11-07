using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CenterSurrounder : MonoBehaviour
{
    public GameObject OriginalSurrounderObject;
    public int SurrounderObjectCount;
    public float angleStep = 360.0f;

    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;

    void Start()
    {
        SurrounderParentTransform = new GameObject(gameObject.name + " Surrounder Parent").transform;
        StartCoroutine(SurroundStepAnimated());
    }
    
    IEnumerator SurroundStepAnimated()
    {
        yield return new WaitForSeconds(AppearWaitDuration);

             angleStep  /= SurrounderObjectCount;

        OriginalSurrounderObject.transform.SetParent(SurrounderParentTransform);

        for (int i = 1; i < SurrounderObjectCount; i++)
        {
            GameObject newSurrounderObject = Instantiate(OriginalSurrounderObject);

            newSurrounderObject.transform.RotateAround(transform.position, Vector3.up, angleStep * i);
            newSurrounderObject.transform.SetParent(SurrounderParentTransform);

            yield return new WaitForSeconds(AppearWaitDuration);
        }

    }
}
