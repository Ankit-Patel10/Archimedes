using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

    //create a new animator variable
    Animator anim;

    //create new public variables that you are able to set in the inspector within unity
    public DoorTrigger[] doorTrig;    
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
        //set the button to go down
        anim.SetBool("goDown", true);

        //open each of the doors connected to the switch by setting the trigger to be true
        foreach (DoorTrigger trigger in doorTrig)
        {
            trigger.Toggle(true);
        }
    }

    //when the switch is deactivated, execute the following statements
    void OnTriggerExit2D()
    {
        //if the stick variable is set true in inspector, keep the button pressed down and return
        if (sticks)
            return;

        //else set the animation of the button to defalt position
        anim.SetBool("goDown", false);

        //close each of the doors connected to the switch by setting the trigger to be false
        foreach (DoorTrigger trigger in doorTrig)
        {
            trigger.Toggle(false);
        }
    }


    void OnDrawGizmos()
    {
        //set the colour of the gizmos that will be drawn
        Gizmos.color = Color.cyan;

        //for each of the doors connected to the switch, draw a line between the switch and the door
        foreach (DoorTrigger trigger in doorTrig)
        {
            Gizmos.DrawLine(transform.position, trigger.transform.position);
        }
    }
}
