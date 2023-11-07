using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TransformFollow : MonoBehaviour
{
    public Transform palmTransform;
    public Transform childTransform;
    public Vector3 childSetVector3;
    
   /// <summary>
   /// Sets a new position every frame for just the x and z value.
   /// </summary>

    // Update is called once per frame
    void Update()
    {
        CopyHandPosition();
    }

    private void CopyHandPosition()
    {
        childSetVector3 = new Vector3(palmTransform.position.x, 0, palmTransform.position.z);
        childTransform.position = childSetVector3;
    }
}
