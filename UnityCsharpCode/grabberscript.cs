using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabberscript : MonoBehaviour
{
    //create new RaycastHit2D variable
    RaycastHit2D hit;

    //create new public variables that you are able to set in the inspector within unity
    public bool grabbed;
    public float distance;
    public Transform holdpoint;
    public float throwforce;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if the E key is pressed on the keyboard...
        if (Input.GetKeyDown(KeyCode.E))
        {
            //...if nothing is already grabed...
            if (!grabbed)
            {
                //pick up the object in front if the player at a certian distance from the player
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

                //if the collider has something in it...
                if (hit.collider != null)
                {
                    //set grabbed variable to true
                    grabbed = true;
                }
            }
            //...if something has already been grabbed...
            else
            {
                //...if the E key is pressed on the keyboard in the keyboard and something has been grabbed...
                if (Input.GetKeyDown(KeyCode.E) && grabbed == true)
                {
                    //set the grab variable to false
                    grabbed = false;

                    //if the object grabbed has the tag "throwableObject"...
                    if (hit.collider.gameObject.CompareTag("throwableObject"))
                    {
                        //throuw the object with a specified force
                        hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;
                    }   
                }
            }
        }
        //if there is something grabbed...
        if (grabbed)
        {
            //set the object that is being held at a certian position away from the player object
            hit.collider.gameObject.transform.position = holdpoint.position;
        }
    }
}
