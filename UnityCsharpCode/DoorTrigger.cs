using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

    //create new public variables that you are able to set in the inspector within unity
    public DoorScript door;
    public bool ignoreTrigger;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //when an object collides with the object
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the ignorTrigger is set true, exit
        if (ignoreTrigger)
            return;

        //if the object has the tag "Player" open the door
        if (other.tag == "Player")
            door.DoorOpens();

    }

    //when the object stops interacting with the object
    void OnTriggerExit2D(Collider2D other)
    {
        //if the ignorTrigger is set true, exit
        if (ignoreTrigger)
            return;

        //if the object has the tag "Player" close the door
        if (other.tag == "Player")
            door.DoorCloses();

    }


    public void Toggle(bool state)
    {
        //if the state is true, open the door, else close the door
        if (state)
            door.DoorOpens();
        else
            door.DoorCloses();
    }


    void OnDrawGizmos()
    {
        //if ignoorTrigger variabe is not set as true...
        if (!ignoreTrigger)
        {
            //set box variable to the BoxCollider2D component if the object interacting with it
            BoxCollider2D box = GetComponent<BoxCollider2D>();
            //draw a wireframe box with center at a certian position with a certian size
            Gizmos.DrawWireCube(transform.position, new Vector2(box.size.x, box.size.y));

        }
    }
}