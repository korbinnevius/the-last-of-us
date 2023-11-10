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
            Instantiate(vfxEmpty);
            GameMgrScriptableObject.roundScore += 5;
            Destroy(gameObject); 
        }
        
    }
}
