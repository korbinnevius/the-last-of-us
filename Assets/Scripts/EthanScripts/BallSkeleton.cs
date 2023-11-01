using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BallSkeleton : MonoBehaviour
{
    private Rigidbody _rigidbody;
    //target can be an empty for the object, this script is attached to, to rotate around
    public Transform center;

    private float radius = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        radius = Vector3.Distance(transform.position, center.position);
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 vel = _rigidbody.velocity;
        Vector3 dirToCenter = new Vector3(center.position.x,transform.position.y,center.position.z) - transform.position;//center - position
        dirToCenter.Normalize();//magnitude of 1
        Vector3 desired = Vector3.ProjectOnPlane(vel, dirToCenter);
        _rigidbody.velocity = desired.normalized * vel.magnitude;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        //Bounce off and Destroy Bricks
        // if (collision.gameObject.CompareTag("Brick"))
        // {
        //     //Brick();
        // }
        
        //Ball Kill Zone or Game Over
        //KillZone
    }

    //Bounce off Player Paddle
    
    //Bounce of Environment
    
    
    
    //The Plain the Ball is Mapped To
}
