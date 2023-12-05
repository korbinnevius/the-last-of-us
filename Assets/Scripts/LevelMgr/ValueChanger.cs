using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueChanger : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    void Start()
    {
        GameMgrScriptableObject.sceneTrans = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
