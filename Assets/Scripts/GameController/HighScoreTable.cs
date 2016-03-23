using UnityEngine;
using System.Collections;
using System;

public class HighScoreTable : MonoBehaviour {

    // **************************************
    //  Scores stored in string "Score" + num
    // ************************************** 

    // Arraylist which stores 10 scores
    public static ArrayList storeHighScores = new ArrayList(10);

    public static int[] saveHighScores = new int[10];

    public int[] testArray = new int[5];

    private int firstGo = 0;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < testArray.Length; i++)
        {

            //Save the new high scores to disk
            PlayerPrefs.DeleteKey("TestScore" + i);

        }

        // Load the variable FirstPlay
        firstGo = PlayerPrefs.GetInt("FirstPlay");

        // If no high scores present then write to disk
        if (firstGo == 0)
        {

            var temp = 10;

            for (int i = 0; i < saveHighScores.Length; i++)
            {

                //Save the new high scores to disk
                PlayerPrefs.SetInt("Score" + i, temp);

                temp += 10;

            }

            firstGo = 1;

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

        // Using normal array
        saveHighScores[0] = newHighScore;

        // sort the array 
        //storeHighScores.Sort();

        //=======================================
        //using normal array
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

    // If the device has no high scores stored then create them 
    //public void createHighScores()
    //{

    //    var temp = 10;

    //    for (int i = 0; i < saveHighScores.Length; i++)
    //    {

    //        saveHighScores[i] = temp;

    //        temp += 10;

    //    }

    //}

}// End class HighScoreTable
