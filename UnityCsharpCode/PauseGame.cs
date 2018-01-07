using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {
// Intializing all transforms, that is the initial canvas for the pause menu, the pause menu, the audio settings, the video settings, and the player
    public Transform canvas;
    public Transform pauseMenu;
    public Transform soundsMenu;
    public Transform videoSettingsMenu;
    public Transform Player;
    SaveGame saveGame;

    void Start()
    {

    }
    
    // Update is called once per frame
    // If 'Escape' is pressed, call the function pause which pauses the game.
    
    void Update () {
	    
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
        
	}
	
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            
            if(pauseMenu.gameObject.activeInHierarchy == false)
            {
                // If the game is not paused, open up ONLY the pause menu, and set the other menus to false
                pauseMenu.gameObject.SetActive(true);
                soundsMenu.gameObject.SetActive(false);
                videoSettingsMenu.gameObject.SetActive(false);
                controlsMenu.gameObject.SetActive(false);
            }
            
            // Freeze the game when the pause menu opens
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
        else
        {
            // If the game is already paused and the Pause Button is pressed, unfreeze the game and set the pause menu to false
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void reset() 
    {
        // If the reset button is pressed, reset the scene to the intial build index and unpause
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
        
        Pause();
    }

    public void Sounds(bool Open)
    {
        // Set the audio settings to open and close the pause menu
        if(Open)
        {
            soundsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        // Set the audio settings to close and open the pause menu once more
        else
        {
            soundsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }

    public void VideoSettings(bool Open)
    {
        // Set the video settings to open and close the pause menu
        if (Open)
        {
            videoSettingsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        // Set the video settings to close and open the pause menu once more
        else
        {
            videoSettingsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
    /* This code is to be implemented later, the controls menu is not currently functioning
    public void Controls(bool Open)
    {
        if (Open)
        {
            controlsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        else
        {
            controlsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
    */



}
