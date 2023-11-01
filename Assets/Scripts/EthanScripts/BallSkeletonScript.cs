using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BallSkeletonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        //Bounce off and Destroy Bricks
        if (collision.gameObject.CompareTag("Brick"))
        {
            //Brick();
        }
        //Ball Kill Zone or Game Over
        //KillZone
    }

    //Bounce off Player Paddle
    
    //Bounce of Environment
    
    
    
    //The Plain the Ball is Mapped To
}
