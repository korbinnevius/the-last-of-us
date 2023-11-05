using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int bricksDestroyed = 0;
    public int lvlOneAmntBricksDestroy=32;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bricksDestroyed == lvlOneAmntBricksDestroy)
        {
            TransitionLevel();
        }
    }
 
        
}
