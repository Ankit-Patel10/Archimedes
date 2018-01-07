using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionScript : MonoBehaviour {

    public float resolution = 5;


    public void Resolution2(int a)
    {
        resolution = a;
    }

	/* Depending on the index choosen on the slider, located within the video settings menu, changing the 
	   resolution of the game. 
	*/ 
	void Start () {
        if (resolution == 1)
        {
            Screen.SetResolution(640, 480, true);
        }
        else if(resolution == 2)
        {
            Screen.SetResolution(1024, 576, true);
        }
        else if(resolution == 3)
        {
            Screen.SetResolution(1280, 720, true);
        }
        else if(resolution == 4)
        {
            Screen.SetResolution(1600, 900, true);
        }
        else if(resolution == 5)
        {
            Screen.SetResolution(1920, 1080, true);
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
