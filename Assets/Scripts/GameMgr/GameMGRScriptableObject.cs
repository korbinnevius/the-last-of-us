using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameMGRScriptableObject",menuName = "ScriptableObjects/GameManagerSO")]
public class GameMGRScriptableObject : ScriptableObject
{
    public int totalLives;
    public int bricksDestroyed;
    public int startBricksInScene;
    public int totalBounces;
    public int totalScore;
    public int roundScore;
    public int spawnProbability;
    public bool sceneTrans;
    //Spawner Properties
    public int spawnerSpinSpeed;
    public int maxBrickCount;
    //Ball Properties
    public float yAxisForce;
    public int bounceForce;


}
