using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BallSkeleton : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [Tooltip("target can be an empty for the object, this script is attached to, to rotate around. Can be empty.")]
    [SerializeField] private Transform center;

    private float radius;
    // Start is called before the first frame update
    private void Awake()
    {
        
        _rigidbody = GetComponent<Rigidbody>();
        SetRadiusToCurrent();
        
        //make the center property not required, just use world center if it's not set.
        //Create center object if it doesnt exist.
        if (center == null)
        {
            center = new GameObject().transform;
            center.gameObject.name = "Center";
            center.transform.position = Vector3.zero;
        }
    }

    private void SetRadiusToCurrent()
    {
        radius = Vector3.Distance(new Vector3(center.position.x,transform.position.y,center.position.z), transform.position);
    }

    private void FixedUpdate()
    {
        //the center, but at our y position.
        Vector3 centerAtY = new Vector3(center.position.x, _rigidbody.position.y, center.position.z);
        
        //A vector that is like the hand of a clock. uh, except arrow pointing inwards.
        Vector3 dirToCenter =  (centerAtY - _rigidbody.position).normalized;//center - position
        
        //lock velocity to plane
        Vector3 desired = Vector3.ProjectOnPlane(_rigidbody.velocity, dirToCenter);
        _rigidbody.velocity = desired.normalized * _rigidbody.velocity.magnitude;
        
        //snap radius so it doesn't drift in or out.
        //normalize * radius means we are exactly radius away from centerAtY.
        _rigidbody.position = centerAtY - (dirToCenter*radius);
    }

    //Bounce off Player Paddle
    
    //Bounce of Environment
    
    
    
    //The Plain the Ball is Mapped To
}
