using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextonScreen : MonoBehaviour 
{
    //create a new animator variable
    Animator anim;

    //create new public variables that you are able to set in the inspector within unity
    public Transform platforms;
    public Transform Canvas;
    public bool sticks;

    // Use this for initialization
    void Start()
    {
        //set anim as the animator of the button
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //when the switch is activated, execute the following statements
    void OnTriggerStay2D()
    {
        //set the button to go down and set the canvas object as active
        anim.SetBool("goDown", true);
        Canvas.gameObject.SetActive(true);
    }

    //when the switch is deactivated, execute teh following statements
    void OnTriggerExit2D()
    {
        //if the stick variable is set true in inspector, keep the button pressed down and return
        if (sticks)
            return;

        //else set the animation of the button to defalt position and deactivate the canvas object
        anim.SetBool("goDown", false);
        Canvas.gameObject.SetActive(false);
    }
}