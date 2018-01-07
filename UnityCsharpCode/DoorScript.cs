using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    // Intialzing the components that are used
    Animator anim;
    
    
    public AudioClip DoorOpensSound;
    public AudioClip DoorClosesSound;
    public float volume;
    AudioSource audio;
    AudioSource audio2;

    public int status = 1;
    // Use this for initialization
    void Start()
    {
        // Gathering all the components of the sound from the object this script is attached to within unity
        audio = GetComponent<AudioSource>();
        audio2 = GetComponent<AudioSource>();
        
        // Setting the intial volume
        volume = 0.8f;
        
        // Gathering the animator component attached to the door
        anim = GetComponent<Animator>();
    }

    // Allowing the volume to be changed via a slider attached to the pause menu
    public void ChangeVolume(float volume2)
    {
        volume = volume2;
    }

    
    public void DoorOpens()
    {
        // When the door opens, play the animaton and play the sound of the door opening only once, unless the door has been closed again
        anim.SetBool("Opens", true);
        if (status == 1) {
            audio.PlayOneShot(DoorOpensSound, volume);
            status = 0;
        }
    }

    public void DoorCloses()
    {
        // When the door closes, play the animation for it to close and play the sound of the door closing, set the status of the door sound opening to 1, such that it can be played again
        anim.SetBool("Opens", false);
        audio.PlayOneShot(DoorClosesSound, volume);
        status = 1;
    }

    // Enable the door to have a collider when it is closed
    void CollEnable()
    {
        GetComponent<Collider2D>().enabled = true;
    }

    // Disable the collider for the door when it is open
    void CollDisable()
    {
        GetComponent<Collider2D>().enabled = false;
    }



}