using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPowerUpMusic : MonoBehaviour
{
    public AudioClip _powerUp;
    private AudioSource _audioSource;
   // private bool musicPlaying;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        //musicPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        // For testing on the keyboard
        
        if (Input.GetKeyDown(KeyCode.M))
        {
           // musicPlaying = false;
            _audioSource.clip = _powerUp;
            _audioSource.Play();
            Debug.Log("I am pressing m");
        }
        
        if (Input.GetKeyDown(KeyCode.N))
        {
            _audioSource.clip = _powerUp;
            _audioSource.Stop();
        }
    }
}
