using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Input = TiltFive.Input;
using Unity.Mathematics;
using UnityEngine.Serialization;

public class PaddleController : MonoBehaviour
{
    /// <summary>
    /// Controlls the rotation of a object. This is a preliminary movement controller to make a more satisfying one
    /// in th efuture
    /// </summary>

    public GameObject parentRotationalObject;
    [FormerlySerializedAs("_rotationalVector3")] [SerializeField]
    private Quaternion _movementQuaternion;

    public float rotationDegree;
    public float rotationalSpeed;
    
    void Start()
    {
        _movementQuaternion = new Quaternion(0, rotationDegree, 0, 0);
        
    }
    
    void Update()
    {
        
        parentRotationalObject.transform.rotation *= Quaternion.Euler(0, rotationDegree, 0);
        //Mathf.Clamp(rotationDegree, 0.1f, 359.9f);
    }
    
    

    public void RotateLeft()
    {
        rotationDegree = rotationalSpeed * Time.deltaTime;
        //Debug.Log("called left");
    }

    public void RotateRight()
    {
        rotationDegree = -rotationalSpeed * Time.deltaTime;
        //Debug.Log("Called right");
    }

    public void NoRotation()
    {
        rotationDegree = 0;
    }
}
