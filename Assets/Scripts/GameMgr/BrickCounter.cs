using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCounter : MonoBehaviour
{
    public int startBrickCount;
    public int brickCount;
    public bool doBrickCount;

    public GameMGRScriptableObject GameMgrScriptableObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (doBrickCount)
        // {
        //     BegginingBrickCount();
        // }
        GameMgrScriptableObject.startBricksInScene = 5;
        
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
