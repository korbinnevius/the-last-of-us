using UnityEngine;
using UnityEngine.Serialization;


public class ClearValues : MonoBehaviour
{
    public GameMGRScriptableObject gameMgrScriptableObject;
    public int startBrickSpawnProbability;

    private void Awake()
    {
        ManagerBaseValues();
    }
    

    private void Start()
    {
        Destroy(gameObject);
    }

    void ManagerBaseValues()
    {
        gameMgrScriptableObject.totalLives = 3;
        gameMgrScriptableObject.bricksDestroyed = 0;
        gameMgrScriptableObject.totalBounces = 0;
        gameMgrScriptableObject.totalScore = 0;
        gameMgrScriptableObject.roundScore = 0;
        gameMgrScriptableObject.startBricksInScene = 0;
        gameMgrScriptableObject.spawnProbability = startBrickSpawnProbability;
        //resetting transition scene bool
        gameMgrScriptableObject.sceneTrans = false;
        //Adding new juice value changes
        gameMgrScriptableObject.spawnerSpinSpeed = 100 ;
        //Increase Max Brick Count
        gameMgrScriptableObject.maxBrickCount = 6;
        //was 120 and 200
        gameMgrScriptableObject.yAxisForce = -70;
        gameMgrScriptableObject.bounceForce = 60;
    }
}
