using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnCollisionDestroyText : MonoBehaviour
{
    public GameObject destroyText;
    private int hitAmount;

    private void OnCollisionEnter(Collision other)
    {
        if (CompareTag("Brick"))
        {
            Destroy(destroyText);
        }

    }
}
