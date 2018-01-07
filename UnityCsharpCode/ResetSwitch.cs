using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSwitch : MonoBehaviour {

	//create new animator variable
	Animator anim;

	//create new public vairbale sticks that can be set in the inpector within unity 
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
		//set the button to go down and reload the current level (reseting the level)
		anim.SetBool("goDown", true);
		SceneManager.LoadScene("ArchimedesLevel6");
	}

	void OnTriggerExit2D()
	{
		//if the stick variable is set true in the inpector, keep the button pressed down and return
		if (sticks)
			return;

		//else set the animator of the button to the defalt position
		anim.SetBool("goDown", false);
	}
}
