using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesChangeSoundEffect : MonoBehaviour
{
    public AudioSource loseAudio;
    public GameMGRScriptableObject GameMgrScriptableObject;

    private int livesCheck;
    void Start()
    {
        livesCheck = GameMgrScriptableObject.totalLives;
    }

    // Update is called once per frame
    void Update()
    {
        if (livesCheck !=GameMgrScriptableObject.totalLives)
        {
            loseAudio.Play();
            livesCheck = GameMgrScriptableObject.totalLives;
        }
    }
}
