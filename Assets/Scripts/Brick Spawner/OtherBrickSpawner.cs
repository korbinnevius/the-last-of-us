using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CenterSurrounder : MonoBehaviour
{
    public GameObject OriginalSurrounderObject;
    public int SurrounderObjectCount;
    public BrickMove _brickMove;
    
    //Movement Variables
    public Transform target;
    public float speed = 3.0f;

    private readonly float AppearWaitDuration = 0.3f;
    private Transform SurrounderParentTransform;

    void Start()
    {
        SurrounderParentTransform = new GameObject(gameObject.name + " Surrounder Parent").transform;
        StartCoroutine(SurroundStepAnimated());
        transform.position = Vector3.MoveTowards(transform.position,target.position, speed * Time.deltaTime);

        //Surround();
    }

    private void Update()
    {
        _brickMove.MoveBrick();
    }

    IEnumerator SurroundStepAnimated()
    {
        yield return new WaitForSeconds(AppearWaitDuration);

        float AngleStep = 360.0f / SurrounderObjectCount;

        OriginalSurrounderObject.transform.SetParent(SurrounderParentTransform);

        for (int i = 1; i < SurrounderObjectCount; i++)
        {
            GameObject newSurrounderObject = Instantiate(OriginalSurrounderObject);

            newSurrounderObject.transform.RotateAround(transform.position, Vector3.up, AngleStep * i);
            newSurrounderObject.transform.SetParent(SurrounderParentTransform);

            yield return new WaitForSeconds(AppearWaitDuration);
        }

    }
    public void MoveBrick()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.position, speed * Time.deltaTime);
    }
}
