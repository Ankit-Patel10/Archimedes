using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleport : MonoBehaviour 
{
    //create new audio variable
    AudioSource audio;

    //create new public variables that you are able to set in the inspector within unity
    public GameObject currentInterObj = null;
    public AudioClip sound;
    public float volume;
    
    // Use this for initialization
    void Start()
    {
        //initialize audio variables
        audio = GetComponent<AudioSource>();
        volume = 0.8f;
    }

    //when the player collides with the exit object execute the following statements
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the object the player collided with has the tag "teleporterObject" execute the following statements
        if (other.CompareTag("teleportObject"))
        {
            //get the current scene, increment the scene by one, and then load the new scene
            int scene = SceneManager.GetActiveScene().buildIndex;
            scene += 1;
            SceneManager.LoadScene(scene);
        }
    }
}
