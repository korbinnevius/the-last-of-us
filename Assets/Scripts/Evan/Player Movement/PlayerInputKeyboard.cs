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
    
    //Sound
    public AudioClip _metalGrinding;
    private AudioSource _audioSource;

    // Update is called once per frame

    private void Awake()
    {
        _paddleController = GetComponent<PaddleController>();
        _audioSource = GetComponent<AudioSource>();
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
            
            //Sorry Evan, Malik is putting in some sound effects here.
            
            _audioSource.clip = _metalGrinding;
            _audioSource.Play();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _paddleController.RotateLeft();
            
            //Sorry Evan, Malik is putting in some sound effects here.
            
            _audioSource.clip = _metalGrinding;
            _audioSource.Play();
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
