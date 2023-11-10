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

    [SerializeField] private BallSkeleton ballSkeleton;

    public bool ballLaunched;

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
