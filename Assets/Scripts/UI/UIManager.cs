using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameMGRScriptableObject GameMgrScriptableObject;
    public string messageToDisplay;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = messageToDisplay + GameMgrScriptableObject.roundScore;
    }
}