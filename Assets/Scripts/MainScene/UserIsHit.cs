using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UserIsHit : MonoBehaviour {

    private int highScore;

    private HighScoreTable hst;

	// Use this for initialization
	void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Referenece to HighScoreTable script
        hst = camera.GetComponent<HighScoreTable>();

        // Store high score for comparison
        highScore = PlayerPrefs.GetInt("High Score");

    }
	
	// Update is called once per frame
	void Update () {
	
	}


    // Triggers end of current session
    void OnCollisionEnter2D(Collision2D coll)
    {

        // If player collides with enemy
        if (coll.gameObject.tag == "enemy" || coll.gameObject.tag == "enemy")
        {

            //If the high score is greater than the current sessions score
            if (highScore > GameControl.score)
            {
                // Save score when player dies
                PlayerPrefs.SetInt("High Score", highScore);
            }
            else if (highScore == GameControl.score) // High score was equaled but not beaten
            {
                // Save score when player dies
                PlayerPrefs.SetInt("High Score", highScore);
            }
            else // New high score set so store the current sessions score
            {

                // Stores the high score
                PlayerPrefs.SetInt("High Score", GameControl.score);

            }

            // Using normal array
            var temp = HighScoreTable.saveHighScores[0];

            // If current session score is greater than the smallest high score
            if (GameControl.score > temp)
            {

                // pass current session score in get saved
                hst.onDeathHighScore(GameControl.score);

            }

            // Want to yield for a couple of seconds as music fades out

            // Load game over screen
            SceneManager.LoadScene("GameOverScreen");

        }// End if

    }// End OnCollisionEnter2D 

}// End class UserIsHit
