using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour {
    public Transform Player;


// Loading the position of the player and the position of the camera when the game was last saved
    void Awake()
    {
        Player.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
        Player.eulerAngles = new Vector3(0,PlayerPrefs.GetFloat("Cam_y"),0);
    }


// Setting the position of the player and camera when the game is quit
    public void SaveGameSettings(bool Quit)
    {
        PlayerPrefs.SetFloat("x", Player.position.x);
        PlayerPrefs.SetFloat("y", Player.position.y);
        PlayerPrefs.SetFloat("z", Player.position.z);
        PlayerPrefs.SetFloat("Cam_y", Player.eulerAngles.y);
        if (Quit)
        {
            
            // The game is paused in the pausemenu, so the timescale must be set back to 1 before returning to the Main  Menu, or else the game will be frozen
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
