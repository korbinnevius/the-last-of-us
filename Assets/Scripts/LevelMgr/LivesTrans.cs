using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesTrans : MonoBehaviour
{

    public GameMGRScriptableObject GameMgrScriptableObject;
    void Update()
    {
        if (GameMgrScriptableObject.totalLives <= 0)
        {
            GameMgrScriptableObject.sceneTrans = true;
        }
    }
}
