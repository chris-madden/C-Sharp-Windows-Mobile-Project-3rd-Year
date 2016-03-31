using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public Text scoreText, highScoreText, missileAmount;
    public static int score, numOfMissiles;
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
	
    // Adds to current score and updates it in the UI
    public void AddScore(int newScore)
    {

        if (isDead == false)
        {
            score += newScore;
            UpdateScore();
        }
       
    }//End AddScore()

    // Will update the UI with the new score
    public void UpdateScore()
    {
      
         scoreText.text = "Score: " + score.ToString();
       
    }// End UpdateScore

    // When player gets the extraMissile sprite they get extra missiles
    public void addMissiles(int extraMissiles)
    {

        GameControl.numOfMissiles += extraMissiles;
        UpdateMissiles();

    }// End addMissiles()

    public void subtractMissiles(int numOfMissiles)
    {

        GameControl.numOfMissiles--;
        UpdateMissiles();

    }// End subtractMissiles()

    public void UpdateMissiles()
    {

        missileAmount.text = "X " + GameControl.numOfMissiles;

    }// End UpdateMissiles()

}// End class GameControl
