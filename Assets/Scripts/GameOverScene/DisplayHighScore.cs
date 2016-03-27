using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour {

    public Text highScoreText, currrentScore;

    private int highScore;

	// Use this for initialization
	void Start () {

        currrentScore.text = GameControl.score.ToString();

        // Store high score in variable
        highScore = PlayerPrefs.GetInt("High Score");

        // Show high score in UI
        highScoreText.text = highScore.ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}// End DisplayHighScore
