using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpin : MonoBehaviour
{
    public float rotationSpeed;

    private float rotationConstantSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rotationConstantSpeed = rotationSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0,rotationConstantSpeed,0);
    }
}
