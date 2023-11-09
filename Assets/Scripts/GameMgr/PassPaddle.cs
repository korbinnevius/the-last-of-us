using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PassPaddle : MonoBehaviour
{
    [SerializeField] private GameMGRScriptableObject gameMgrScriptableObject;

    public UnityEvent PaddleHasBeenPassedEvent;
    
    //This script is called on a on trigger enter. Calls a coroutine that subtracts a life and resets the ball
    //back to its paddle to be launched again.


    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ThePaddleHasBeenPassed());
    }

    private IEnumerator ThePaddleHasBeenPassed()
    {
        gameMgrScriptableObject.totalLives -= 1;
        yield return new WaitForSeconds(3);
        PaddleHasBeenPassedEvent.Invoke();
        yield return null;
    }
}
