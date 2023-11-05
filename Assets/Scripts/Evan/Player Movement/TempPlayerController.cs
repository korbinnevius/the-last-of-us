using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Input = TiltFive.Input;

public class TempPlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private float tiltx;
    private float tilty;
    
    private Vector3 movementVector3; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RotateMovement()
    {
        tiltx = Input.GetStickTilt().x;
        tilty = Input.GetStickTilt().y;
        
        movementVector3 = new Vector3(tiltx, tilty, 0f);

        transform.position = movementVector3;
    }
}
