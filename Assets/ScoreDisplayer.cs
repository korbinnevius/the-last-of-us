using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Final Score: " + GameMgrScriptableObject.totalScore.ToString();
    }
}
