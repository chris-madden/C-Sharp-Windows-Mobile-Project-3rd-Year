using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Code used for testing local storage on device that had scored saved from a previous build
        //PlayerPrefs.DeleteAll();

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

    public void quitGame()
    {

        Application.Quit();

    }
}
