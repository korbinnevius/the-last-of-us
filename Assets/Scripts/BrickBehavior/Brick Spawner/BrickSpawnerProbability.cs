using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BrickSpawnerProbability : MonoBehaviour
{
    [Description("This is the description for SpaceKey")]
    public GameObject brick;
    public int spawnProbability;
    
    private GameObject empty;
    // Start is called before the first frame update
    void Start()
    {
        //Setting private gameobject = to nothing
        empty = new GameObject();
        RandomSpawn();
    }
    
    private void RandomSpawn()
    {
        int spawnPick = Random.Range(0, spawnProbability);
       if (spawnPick == 0)
       {
           Instantiate(brick);
       }
       else
       {
           Instantiate(empty);
       }
   }
}
