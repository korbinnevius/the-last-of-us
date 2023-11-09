
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BallResetToPaddleController : MonoBehaviour
{
    [SerializeField] private GameObject ballObject;
    [SerializeField] private Rigidbody ballRidgidbody;

    [SerializeField] private GameObject paddleObjectTransform;

    /// <summary>
    /// This is a function controller for the Pass Paddle manager to call. It will call until it recognizes that
    /// a bool has been set to false.
    /// </summary>
    // Update is called once per frame
    private void Update()
    {
        AttatchToPaddle();
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
