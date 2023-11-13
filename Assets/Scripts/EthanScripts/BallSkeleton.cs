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

    //For testing and can be accessed by other scripts for gameplay
    public float XAxisForce;
    public float YAxisForce;
    public float ZAxisForce;
    
    public float MaxSpeed = 50f;
    public float MaxSpeedRateOT;
    public float BounceForce = 0f;

    private bool BallIsLaunched;

    private float radius;
    // Start is called before the first frame update
    private void Awake()
    {
        
        _rigidbody = GetComponent<Rigidbody>();
        SetRadiusToCurrent();
        SetMaxVelocity();
        
        BallLaunch();
        
        //make the center property not required, just use world center if it's not set.
        //Create center object if it doesnt exist.
        if (center == null)
        {
            center = new GameObject().transform;
            center.gameObject.name = "Center";
            center.transform.position = Vector3.zero;
        }
    }
    
    //Setting the radius of the object from the "center" based on where the object is in world space
    private void SetRadiusToCurrent()
    {
        radius = Vector3.Distance(new Vector3(center.position.x,transform.position.y,center.position.z), transform.position);
    }

    //Setting the max speed for the "ball" that can be increased later
    private void SetMaxVelocity()
    {
        _rigidbody.maxLinearVelocity = MaxSpeed;
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

    private void Update()
    {
        
        MaxSpeed = MaxSpeed + MaxSpeedRateOT * Time.deltaTime ;
        //Debug.Log(_rigidbody.velocity.magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("boop");
        _rigidbody.AddForce(collision.impulse.normalized * BounceForce,ForceMode.Force);
        //Debug.Log("Collided");
        
    }

    public void BallLaunch()
    {
        
        _rigidbody.AddForce(XAxisForce, YAxisForce, ZAxisForce, ForceMode.Impulse);
        BallIsLaunched = true;
    }
  
}
