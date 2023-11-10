using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HandInputRidgidbodyCharacterController : MonoBehaviour
{
    /// <summary>
    /// Refrences 2 objects, parent transform object and the childTargetObject.
    /// This will use the Quaternion look towards to set the rotation of the parent object to the position
    /// of the childTarget
    /// </summary>

    public GameObject childTargetObject;
    public GameObject sampleRotationObject;

    [SerializeField] private BallSkeleton ballSkeleton;

    [SerializeField] private Rigidbody parentObjectRigidbody;

    public bool ballLaunched;

    // Update is called once per frame

    private void Start()
    {
        parentObjectRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        parentObjectRigidbody.MoveRotation(sampleRotationObject.transform.rotation);
    }

    private void Update()
    {
        RotateTowardsChild();
    }

    private void RotateTowardsChild()
    {
        //Sets a vector3.rotation of the parent object that hoasts the paddle under... I want this to
        //now set a random objects rotation in update... and have the parent object Rigidbody
        //rotate the child paddle in fixed update... OK
        Vector3 TargetPositon = childTargetObject.transform.position;
        sampleRotationObject.transform.rotation = Quaternion.LookRotation(TargetPositon, Vector3.up);
    }

    public void PoseHandToLaunch()
    {
        //Will launch ball when the gesture manager detects a pinch.
        if (!ballLaunched)
        {
            ballSkeleton.BallLaunch();
        }
        Debug.Log("I have been posed!");
        ballLaunched = true;
    }
    
    public void setLaunchBool()
    { 
        ballLaunched = false;
    }
}
