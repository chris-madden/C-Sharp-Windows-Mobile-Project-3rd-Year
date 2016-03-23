using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

       

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void reloadGame()
    {
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
