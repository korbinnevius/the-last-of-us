using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInputCharacterController : MonoBehaviour
{
    /// <summary>
    /// Refrences 2 objects, parent transform object and the childTargetObject.
    /// This will use the Quaternion look towards to set the rotation of the parent object to the position
    /// of the childTarget
    /// </summary>

    public GameObject childTargetObject;
    public GameObject parentRotationObject;

    public BallSkeleton ballSkeleton;

    // Update is called once per frame
    void Update()
    {
        RotateTowardsChild();
    }

    private void RotateTowardsChild()
    {
        Vector3 TargetPositon = childTargetObject.transform.position;
        parentRotationObject.transform.rotation = Quaternion.LookRotation(TargetPositon, Vector3.up);
    }

    private void PinchToLaunch()
    {
        //Will launch ball when the gesture manager detects a pinch.
        ballSkeleton.BallLaunch();
    }
}
