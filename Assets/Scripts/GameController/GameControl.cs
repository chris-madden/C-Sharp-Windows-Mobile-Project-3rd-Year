using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static int score, numOfMissiles;
    //private int highScore;
    public Text scoreText, highScoreText, missileAmount;
    public bool isDead = false;
    
	// Use this for initialization
	void Start () {

        // Starting game variables
        score = 0;
        numOfMissiles = 30;

        // UI text
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("Score9");
        UpdateMissiles();
        UpdateScore();

    }// End Start
	
	// Update is called once per frame
	void Update () {

	}

    // Adds to current score and updates it in the UI
    public void AddScore(int newScore)
    {

        if (isDead == false)
        {
            score += newScore;
            UpdateScore();
        }
       
    }

    // Will update the UI with the new score
    public void UpdateScore()
    {
      
         scoreText.text = "Score: " + score.ToString();
       
    }

    // When player gets the extraMissile sprite they get extra missiles
    public void addMissiles(int extraMissiles)
    {

        GameControl.numOfMissiles += extraMissiles;
        UpdateMissiles();

    }

    public void subtractMissiles(int numOfMissiles)
    {

        GameControl.numOfMissiles--;
        UpdateMissiles();

    }

    public void UpdateMissiles()
    {
        missileAmount.text = "X " + GameControl.numOfMissiles;
    }

}
