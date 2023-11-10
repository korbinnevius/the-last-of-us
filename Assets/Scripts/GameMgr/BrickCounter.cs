using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCounter : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    void Update()
    {
        if (GameMgrScriptableObject.startBricksInScene == GameMgrScriptableObject.bricksDestroyed)
        {
            //Restart Scene Logic
            GameMgrScriptableObject.bricksDestroyed = 0;
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
    }

    void BegginingBrickCount()
    {
        GameMgrScriptableObject.startBricksInScene = GameObject.FindGameObjectsWithTag("Brick").Length;
    }
}
