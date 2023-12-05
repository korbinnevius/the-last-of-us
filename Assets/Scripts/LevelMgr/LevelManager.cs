using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public String sceneToMoveTo;
    //
    private void Start()
    {
        //I dont like this logic getting handled here
       // GameMgrScriptableObject.sceneTrans = true;
    }

    private void FixedUpdate()
    {
        if (GameMgrScriptableObject.sceneTrans)
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(sceneToMoveTo);
    }
}
