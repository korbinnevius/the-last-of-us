using System;
using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;
using UnityEngine.Serialization;
using Input = TiltFive.Input;

public class PlayerInput : MonoBehaviour
{
    /// <summary>
    /// input Recieve from the tilt 5 controller.
    /// Using the rotation of the joystick as a baseline control for the position
    /// of the paddle.
    /// </summary>
    /// 
    public float stickTiltx;
    public float stickTilty;

    private ControllerIndex _controllerIndex = ControllerIndex.Right;
    private PlayerIndex _playerIndex;
    public Vector3 inputVector;
    
    
    //input for the x position of the joystick
    public void T5Joystick()
    {
        Vector2 Tilt5input = Input.GetStickTilt(_controllerIndex, _playerIndex);
        //inputVector = (Tilt5input.x, 0f, Tilt5input.y);

    }
    
    //input for the y poition of the tilt 5 joystick to be converted to the Z axis in world space.
    // public float T5Joysticky(float stickPositionX)
    // {
    //     stickPositionX = stickTilty;
    //     return stickPositionX;
    // }
    
}
