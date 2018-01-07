using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSwitch : MonoBehaviour {

	//create new animator variable
	Animator anim;
	
	//create new public variables that you are able to set in the inspector within unity
	public bool sticks;
	public float bouncePower;
	public Rigidbody2D rb;
	public GameObject ply;

	// Use this for initialization
	void Start()
	{
		//initalize vairables created
		anim = GetComponent<Animator>(); //set anim as the animator of the button
		ply = GameObject.FindWithTag ("Player"); //set ply as the game object with tag "Player"
		rb = ply.GetComponent<Rigidbody2D>(); //set rb as the RigidBody2D component of the GameObject "Player"

	}

	// Update is called once per frame
	void Update()
	{
		
	}

	//When the switch is activated, execute the following statements
	void OnTriggerStay2D()
	{
		//set the animation of the button to go down and add force in the y direction to the player
		anim.SetBool("goDown", true);
		rb.AddForce(new Vector2(0f, bouncePower));
	}

	//when the switch is deactivated, execute teh following statements
	void OnTriggerExit2D()
	{
		//if the stick variable is set true in inspector, keep the button pressed down and return
		if (sticks)
			return;

		//else set the animation of the button to defalt position
		anim.SetBool("goDown", false);
	}
}
