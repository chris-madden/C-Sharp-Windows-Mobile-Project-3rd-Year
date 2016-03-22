using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static int score;
    private int highScore;
    public Text scoreText, highScoreText;

	// Use this for initialization
	void Start () {

        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("High Score");
        score = 0;
        UpdateScore();


    }
	
	// Update is called once per frame
	void Update () {
	
	}

    // Adds to current score and updates it in the UI
    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    // Will update the UI with the new score
    public void UpdateScore()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}
