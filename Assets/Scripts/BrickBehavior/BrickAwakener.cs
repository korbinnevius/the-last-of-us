using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickAwakener : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    
    public int scoreForAwaken = 30;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //checking if score gets to 30
        if (GameMgrScriptableObject.totalScore >= scoreForAwaken)//GameMgrScriptableObject.spawnProbability == 1)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameMgrScriptableObject.spawnProbability = 2;
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
