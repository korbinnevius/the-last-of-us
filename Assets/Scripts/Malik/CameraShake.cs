using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float duration = 1f;

    public AnimationCurve curve;

    public bool start = false;
    
   
    
    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.collider.CompareTag("Brick"))
    //     {
    //         StartCoroutine(Shaking());
    //     }
    // }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position; //stores the starting position of the camera.
        float elaspedTime = 0f; //stores the elapsed time since the beginning of the shake.
        
        //while the elapsed time is less that the duration, move the camera position in a random vector.
        while (elaspedTime < duration)
        {
            elaspedTime += Time.deltaTime;
            float strength = curve.Evaluate(elaspedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null; //to continue the execution at the next frame.
        }

        transform.position = startPosition; // returning the camera back to its original position.
    }
}