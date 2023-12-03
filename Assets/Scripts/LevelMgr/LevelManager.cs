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
        GameMgrScriptableObject.sceneTrans = false;
    }

    private void FixedUpdate()
    {
        if (GameMgrScriptableObject.sceneTrans)
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadSceneAsync(sceneToMoveTo);
    }
}
