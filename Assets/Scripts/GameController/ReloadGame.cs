using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour {

    public AudioClip uiSound;

    private AudioSource source;

	// Use this for initialization
	void Start () {

        source = GetComponent<AudioSource>();

        // Set volume of background music
        source.volume = 0.3f;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void reloadGame()
    {
        GameControl.score = 0;

        SceneManager.LoadScene("MainGame");
    }

    public void highScoresScene()
    {

        SceneManager.LoadScene("TopScores");

    }

    public void startScreen()
    {

        SceneManager.LoadScene("StartMenu");

    }

    public void creditsScreen()
    {

        SceneManager.LoadScene("CreditsScreen");

    }

    public void quitGame()
    {

        Application.Quit();

    }

    // Plays audio for button clicks
    public void playUISound()
    {

        source.PlayOneShot(uiSound);

    }
}
