using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;
using UnityEngine.Serialization;
using Input = TiltFive.Input;

public class T5RadialInput : MonoBehaviour
{

    private ControllerIndex _controllerIndex;
    private PlayerIndex _playerIndex;
    private PaddleController _paddleController;

    [FormerlySerializedAs("leftOrRightFloat")] public float StickAxisValueFloat;
    void Start()
    {
        _paddleController = GetComponent<PaddleController>();
    }

    // Update is called once per frame
    void Update()
    {
        stickinput();
    }
    
    // set a git stick tilt ot a float value, if past a certain value set left or right to work inside this script
    // from the player input
    private void stickinput()
    {
        StickAxisValueFloat = Input.GetStickTilt().x;

        if (StickAxisValueFloat >= 0.8f)
        {
            _paddleController.RotateRight();
        }
        else if (StickAxisValueFloat <= -0.8f )
        {
            _paddleController.RotateLeft();
        }
        else
        {
            _paddleController.NoRotation();
        }
    }
   
}
