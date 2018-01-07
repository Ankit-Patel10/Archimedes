using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSwitchScript : MonoBehaviour 
{
	//create a new animator variable
	Animator anim;

	//create new public variables that you are able to set in the inspector within unity
	public bool sticks;
	public Transform switchs;


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
		//set the button to go down and set the switch object as active
		anim.SetBool("goDown", true);
		switchs.gameObject.SetActive(true);
	}

	void OnTriggerExit2D()
	{
		//if the stick variable is set true in the inpector, keep the button pressed down and return
		if (sticks)
			return;

		//else set the animator of the button to the defalt position and deactivate the switch object
		anim.SetBool("goDown", false);
		switchs.gameObject.SetActive(false) ;
	}
}
