using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour {

    public AudioClip uiSound;

    private AudioSource source;

	// Use this for initialization
	void Start () {

        // Code used for testing local storage on device that had scored saved from a previous build
        //PlayerPrefs.DeleteAll();

        source = GetComponent<AudioSource>();

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

        //AudioSource.PlayClipAtPoint(uiSound, transform.position);

        source.PlayOneShot(uiSound);

    }
}
