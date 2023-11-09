using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public GameObject vfxEmpty;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            //Add one to brickLess SO
            GameMgrScriptableObject.bricksDestroyed += 1;
            Instantiate(vfxEmpty);
            GameMgrScriptableObject.roundScore += 5;
            Destroy(gameObject); 
        }
        
    }
}
