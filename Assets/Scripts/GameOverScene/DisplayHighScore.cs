using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour {

    public Text highScoreText, currrentScore;

    private int highScore;

	// Use this for initialization
	void Start () {

        // Display score
        currrentScore.text = GameControl.score.ToString();

        // Store high score in variable
        highScore = PlayerPrefs.GetInt("High Score");

        // Show high score in UI
        highScoreText.text = highScore.ToString();

	}// End Start()
	
}// End class DisplayHighScore
