using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnAwakeTransitionScene : MonoBehaviour
{
    public string sceneToMoveTo;
    void Start()
    {
        SceneManager.LoadSceneAsync(sceneToMoveTo);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
