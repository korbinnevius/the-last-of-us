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
            StartCoroutine(ChangeScene()); 
        }
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadSceneAsync(sceneToMoveTo);
        yield return null;
    }
}
