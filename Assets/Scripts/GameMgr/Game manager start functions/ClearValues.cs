using UnityEngine;


public class ClearValues : MonoBehaviour
{
    public GameMGRScriptableObject gameMgrScriptableObject;

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
        gameMgrScriptableObject.bricksInScene = 0;
    }
}
