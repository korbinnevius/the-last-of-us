using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollision : MonoBehaviour
{
    public AudioClip _ballThump;
    public AudioClip _ballToBrickCollisionSound;
    public AudioClip _cylinderCollision;
    public AudioClip _powerUp;
    public AudioSource _audioSource;
    //public AudioSource _audioSourcePowerUp;

    // Start is called before the first frame update
    void Start()
    {
        // _audioSource = GetComponent<AudioSource>();
        // _audioSourcePowerUp = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Paddle"))
        {

            // When the play collides with any gameobject that is labelled obstacles, the lose panel will be set
            // as active, the timer will stop and the siren sounds will play.


            _audioSource.clip = _ballThump;
            _audioSource.Play();
            Debug.Log("I have made contact with a the paddle");
        }
        if (collision.collider.CompareTag("Brick"))
        {

            // When the play collides with any gameobject that is labelled obstacles, the lose panel will be set
            // as active, the timer will stop and the siren sounds will play.


            _audioSource.clip = _ballToBrickCollisionSound;
            _audioSource.Play();
            Debug.Log("I have made contact with a brick");
        }
        if (collision.collider.CompareTag("Environment"))
        {

            // When the play collides with any gameobject that is labelled obstacles, the lose panel will be set
            // as active, the timer will stop and the siren sounds will play.


            _audioSource.clip = _cylinderCollision;
            _audioSource.Play();
            Debug.Log("I have made contact with the bottom of the cylinder");
        }
        if (collision.collider.CompareTag("Powerup"))
        {
            //_audioSourcePowerUp.clip = _powerUp;
            _audioSource.Play();
           // _audioSourcePowerUp.Play();
            Debug.Log("I have made contact with a the powerup");
        }
    }
}
