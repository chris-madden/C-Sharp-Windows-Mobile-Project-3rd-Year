using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UserIsHit : MonoBehaviour {

    private int highScore;

	// Use this for initialization
	void Start () {

        // Store high score
        highScore = PlayerPrefs.GetInt("High Score");

    }
	
	// Update is called once per frame
	void Update () {
	
	}


    // Triggers end of current session
    void OnCollisionEnter2D(Collision2D coll)
    {

        // If player collides with enemy
        if (coll.gameObject.tag == "enemy")
        {

            // If the high score is greater than the current sessions score
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
                // Save score when player dies
                PlayerPrefs.SetInt("High Score", GameControl.score);
            }

            // Load game over screen
            SceneManager.LoadScene("GameOverScreen");

        }// End if

    }// End OnCollisionEnter2D 

}// End class UserIsHit
