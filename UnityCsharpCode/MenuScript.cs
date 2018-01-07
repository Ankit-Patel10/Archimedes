using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour {

    //create new public vairbale sticks that can be set in the inpector within unity 
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start () {
        //get components 
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}

    //when exit is pressed
    public void ExitPress(){
        //enable quitMenu and disable statText and exitText
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    //when nothing is pressed
    public void NoPress() {
        //disable quitMenu and enable startText and exitText
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        
    }

    //start the game by loading the first level "ArchimedesLevel1"
    public void StartGame()
    {
        SceneManager.LoadScene("ArchimedesLevel1");
    }

    //exit the game by quitting the application
    public void ExitGame() {
        Application.Quit();
    }
}
