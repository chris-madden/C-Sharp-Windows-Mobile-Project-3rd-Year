using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour {

    public AudioClip uiSound;
    private AudioSource source;

	// Use this for initialization
	void Start () {

        // Get a reference to the AudioSource component
        source = GetComponent<AudioSource>();

        // Set volume of background music
        source.volume = 0.3f;

    }
	
    public void reloadGame()
    {

        GameControl.score = 0;

        SceneManager.LoadScene("MainGame");

    }// End reloadGame()

    public void highScoresScene()
    {

        SceneManager.LoadScene("TopScores");

    }// End highScoresScene()

    public void startScreen()
    {

        SceneManager.LoadScene("StartMenu");

    }// End startScreen()

    public void creditsScreen()
    {

        SceneManager.LoadScene("CreditsScreen");

    }// End creditsScreen()

    public void quitGame()
    {

        Application.Quit();

    }// End quitGame()

    // Plays audio for button clicks
    public void playUISound()
    {

        source.PlayOneShot(uiSound);

    }// End playUISound()

}// End class ReloadGame
