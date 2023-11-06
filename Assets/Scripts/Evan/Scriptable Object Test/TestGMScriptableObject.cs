using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "TestGameManagerScriptableObject", menuName = "ScriptableObjects/TestGMSO")]
public class TestGMScriptableObject : ScriptableObject
{
    //values that will be edited and read
    public int lives;
    public int score;
    public int bounceint;
    public int totalBlocks;
    public int stageNum;

    //Next All that needs to be done is these should be edited directly by the ball, blocks, scene manager,
    //and objects in the scene that edit lives (such as pass collider)
}
