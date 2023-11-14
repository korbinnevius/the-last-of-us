
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BallResetToPaddleHandler : MonoBehaviour
{
    [SerializeField] private GameObject ballObject;
    [SerializeField] private Rigidbody ballRidgidbody;

    [SerializeField] private GameObject paddleObjectTransform;

    /// <summary>
    /// This object sets the position of the current ball in scene to a transform parented under the ParentInputObject.
    /// Is meant to be disabled and enabled.
    /// </summary>
    // Update is called once per frame
    private void Update()
    {
        AttatchToPaddle();
        ResetBallMotion();
    }

    private void AttatchToPaddle()
    {
        ballObject.transform.position = paddleObjectTransform.transform.position;
    }

    private void ResetBallMotion()
    {
        ballRidgidbody.velocity = new Vector3(0, 0, 0);
        ballRidgidbody.angularVelocity = new Vector3(0, 0, 0);
    }

    //I want to attatch the ball to paddle while the
}
