using UnityEngine;
using System.Collections;
using System;

public class HighScoreTable : MonoBehaviour {

    // Array which will hold the high scores
    public static int[] saveHighScores = new int[10];

    private int firstGo = 0;

    // Use this for initialization
    void Start () {

        // Load the variable FirstPlay
        firstGo = PlayerPrefs.GetInt("FirstPlay");

        // If no high scores present then write to disk
        if (firstGo == 0)
        {

            var temp = 10;

            // Loop through and write 10 artifical scores to disk
            for (int i = 0; i < saveHighScores.Length; i++)
            {

                //Save the new high scores to disk
                PlayerPrefs.SetInt("Score" + i, temp);

                temp += 10;

            }

            // Set firstGo so it will only work once
            firstGo = 1;

            // Save the variable to disk
            PlayerPrefs.SetInt("FirstPlay", firstGo);

            PlayerPrefs.Save();

        }

        // Taking scores from disk
        loadHighScores();

    }// End Start
	
	// Update is called once per frame
	void Update () {
	
	}

    // Takes high scores off disk and stores in an array list
    public void loadHighScores()
    {

        // Temp variable for each score
        var tempScore = 0;

        // Loop 10 times 
        for (int i = 0; i < saveHighScores.Length; i++)
        {

            // Get score off disk and store in temp variable
            tempScore = PlayerPrefs.GetInt("Score" + i);

            // Save into normal array
            saveHighScores[i] = tempScore;

        }// End for

    }// End loadHighScores

    public void onDeathHighScore(int newHighScore)
    {

        // Overwrite lowest score in table with the new highscore
        saveHighScores[0] = newHighScore;

        // Sort the array from lowest to highest
        Array.Sort(saveHighScores);

        // save to disk
        for (int i = 0; i < saveHighScores.Length; i++)
        {

            // Using normal array
            var normalTemp = saveHighScores[i];

            // Save the new high scores to disk
            PlayerPrefs.SetInt("Score" + i, normalTemp);

        }// End for

    }// End onDeathHighScore

}// End class HighScoreTable
