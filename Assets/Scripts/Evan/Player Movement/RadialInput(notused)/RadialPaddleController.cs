using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Input = TiltFive.Input;
using Unity.Mathematics;
using UnityEngine.Serialization;

public class RadialPaddleController : MonoBehaviour
{
    /// <summary>
    /// has several values that set rotation of object too position.. will use rotate towards
    /// </summary>

    public GameObject parentRotationalObject;
    private Quaternion _movementQuaternion;
    public float rotationDegree;
    public float rotationalSpeed;

    public List<GameObject> paddleRotationPositionList;



    void Start()
    {
        _movementQuaternion = new Quaternion(0, rotationDegree, 0, 0);
        
    }
    
    void Update()
    {
        
        parentRotationalObject.transform.rotation *= Quaternion.Euler(0, rotationDegree, 0);
        //Mathf.Clamp(rotationDegree, 0.1f, 359.9f);
    }



    public void SetRotationOfPaddle()
    {
        // set rotation of object
        // Remember quaternion rotate towards.
    }
}
