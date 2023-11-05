using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject brick;
    public int brickSpawnCount;

    private readonly float appearWaitDuration = .3f;
    public Transform SurrounderParentTransform;
    
    void Start()
    {
        //SurrounderParentTransform = new GameObject(gameObject.name + " Surround Parent").transform;
        StartCoroutine(SurroundStepAnimated());
        
    }

    IEnumerator SurroundStepAnimated()
    {
        yield return new WaitForSeconds(appearWaitDuration);
        
        float angleStep = 360.0f;
        brick.transform.SetParent(SurrounderParentTransform);

        for (int i = 1; i < brickSpawnCount; i++)
        {
            GameObject newBrickSpawnObject = Instantiate(brick);
            
            newBrickSpawnObject.transform.RotateAround(transform.position,Vector3.up, angleStep * i);
            newBrickSpawnObject.transform.SetParent(SurrounderParentTransform);
            
            yield return new WaitForSeconds(appearWaitDuration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
