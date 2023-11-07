using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMove : MonoBehaviour
{
    //Drag Player Transform Here
    public Transform target;
    public float speed = 3;

    void Start()
    {
        MoveBrick();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveBrick()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
