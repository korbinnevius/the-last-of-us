using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public String sceneToMoveTo;
    

    private bool coroutineStarted;
    //
    private void Start()
    {
        coroutineStarted = false;
    }

    private void Update()
    {
        if (GameMgrScriptableObject.totalLives <= 0)
        {
            StartCoroutine(ChangeScene());
        }
    }

    private IEnumerator ChangeScene()
    {
        if (coroutineStarted == false)
        {
            coroutineStarted = true;
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadSceneAsync(sceneToMoveTo);
            yield return new WaitForSeconds(4.0f);
            
        }
        

    }
}
