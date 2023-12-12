using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public GameObject vfxEmpty;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            //whenever the brick gets hit by the ball, add 5 to the score and then destroy the brick
            Instantiate(vfxEmpty);
            vfxEmpty.transform.position = gameObject.transform.position;
            GameMgrScriptableObject.roundScore += 5;
            Destroy(gameObject); 
        }
        
    }

    
}
