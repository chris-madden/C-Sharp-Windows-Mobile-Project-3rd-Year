using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScrollGameOverText : MonoBehaviour {

    // Game over text 
    public RectTransform gameOverTitle;

    private float gameOver = 400, centerScreen = 0;

    public bool isGameOver = false;

    private int highScore;

    private HighScoreTable hst;

    private int stop;

    // Use this for initialization
    void Start () {

        // Get reference to RectTransform of text
        gameOverTitle = GetComponent<RectTransform>();

        // Push text off screen
        alignText();

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Referenece to HighScoreTable script
        hst = camera.GetComponent<HighScoreTable>();

        // Store high score for comparison
        highScore = PlayerPrefs.GetInt("Score9");

        stop = 0;

    }
	
	// Update is called once per frame
	void Update () {

       

        if (isGameOver == true && stop == 0)
        {

            // Should save the final score regardless of whether points were obtained after death
            saveHighScore();

            // Stops method from being called more than once
            stop = 1;

        }

        // isGameOver set to true when player is killed
        if (isGameOver == true && gameOver > centerScreen)
        {

            // Move text left
            gameOver -= 3f;

            // Reposition game over text
            gameOverTitle.anchoredPosition = new Vector2(gameOver, 0);

        }

        // when text hits center of screen load the game over scene
        if (gameOver <= centerScreen)
        {
            loadGameOverScene();
        }

    }// End update

    void alignText()
    {

        // Reposition game over text
        gameOverTitle.anchoredPosition = new Vector2(gameOver, 0);

    }// alignText

    void loadGameOverScene()
    {

        // Load game over screen
        SceneManager.LoadScene("GameOverScreen");

    }// End loadGAmeOver()


    void saveHighScore()
    {

        // Calculate final scores here
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

    }

}// End class ScrollGameOverText
