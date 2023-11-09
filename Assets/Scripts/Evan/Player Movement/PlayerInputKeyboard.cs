using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerInputKeyboard : MonoBehaviour
{
    /// <summary>
    /// Temporary keyboard input script for working on the project without the tilt 5.
    /// This will call the current in use controller.
    /// </summary>
    private PaddleController _paddleController;
    [SerializeField]
    private BallSkeleton ballSkeleton;

    public bool ballLaunched = false;

    public UnityEvent onLaunchEvent; 

    // Update is called once per frame

    private void Awake()
    {
        _paddleController = GetComponent<PaddleController>();
    }

    void Update()
    {
        
        ButtonControlls();
        LaunchBallCall();
    }

    private void ButtonControlls()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _paddleController.RotateRight();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _paddleController.RotateLeft();
        }
        else
        {
            _paddleController.NoRotation();
        }
    }

    private void LaunchBallCall()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ballLaunched)
        {
            onLaunchEvent.Invoke();
            ballSkeleton.BallLaunch();
            ballLaunched = true;
        }
    }

    public void setLaunchBool()
    {
        ballLaunched = false;
    }
}
