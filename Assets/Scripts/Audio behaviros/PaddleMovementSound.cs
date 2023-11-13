using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementSound : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    
    private Rigidbody _paddleRidgedbody;

    private float _velocityReadFloat;

    private void Start()
    {
        _paddleRidgedbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        AudioVolumeByMagnitude();
    }

    private void AudioVolumeByMagnitude()
    {
        //getting the velocity is a vector three... to read these values do I... combine the x and z values to combine into
        //a float?..
        
        

        Debug.Log(_paddleRidgedbody.velocity);
    }
}
