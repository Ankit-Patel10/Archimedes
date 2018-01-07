using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlatformScript : MonoBehaviour
{
    //create a new animator variable
    Animator anim;

    //create new audio variables
    AudioSource audio;
    AudioSource audio2;

    //create new public variables that you are able to set in the inspector within unity
    public Transform platforms;
    public AudioClip sound;
    public AudioClip buttonsound;
    public float volume;
    public int status = 1;
    public int statusbuttonsound = 1;
    public bool sticks;

    // Use this for initialization
    void Start()
    {
        //initialize audio variables
        audio = GetComponent<AudioSource>();
        audio2 = GetComponent<AudioSource>();
        volume = 0.8f;

        //set anim as the animator of the button
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //changes the volume of the audio
    public void ChangeVolume(float volume2)
    {
        //sets the volume to the new volume inputted
        volume = volume2;
    }

    //when the switch is activated, execute the following statements
    void OnTriggerStay2D()
    {
        //set the button to go down and set the platforms object as active
        anim.SetBool("goDown", true);
        platforms.gameObject.SetActive(true);
        
        //if statusbutton sound variable is equal to 1 then execute the following statements
        if (statusbuttonsound  == 1)
        {
            //play the button sound at the volume set and change the statusbuttonsound variable to 0
            audio.PlayOneShot(buttonsound, volume);
            statusbuttonsound = 0;
        }
        
        //if status variable is equal to 1 then execute the following statements
        if (status == 1)
        {
            //play the audio clip sound at the volume set and change status variable to 0
            audio.PlayOneShot(sound, volume);
            status = 0;
        }
    }

    //when the switch is deactivated, execute teh following statements
    void OnTriggerExit2D()
    {
        //if the stick variable is set true in inspector, keep the button pressed down and return
        if (sticks)
            return;

        //else set the animation of the button to defalt position 
        anim.SetBool("goDown", false);

        //set statusbuttonsound equal to 1 and activate the platform object
        statusbuttonsound = 1;
        platforms.gameObject.SetActive(false) ;
    }
}
