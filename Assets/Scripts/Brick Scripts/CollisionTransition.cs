using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTransition : MonoBehaviour
{
    public string sceneToMoveTo;
    private void OnCollisionEnter(Collision other)
    {
            StartCoroutine(ChangeScene());
    }
    
    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(sceneToMoveTo);
        
    }
}
