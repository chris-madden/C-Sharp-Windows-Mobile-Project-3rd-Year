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

    private int capacity = 10;

    // Use this for initialization
    void Start () {

        // Taking scores from disk
        loadHighScores();

        // Taking scores from array
        //printScores();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //void printScores()
    //{

    //    // Loop through array and print scores
    //    for (int i = 0; i < storeHighScores.Count; i++)
    //    {

    //        Debug.Log(storeHighScores[i]);

    //    }// End for

    //}// End printScores

    // Takes high scores off disk and stores in an array list
    void loadHighScores()
    {

        // Temp variable for each score
        var tempScore = 0;

        // Loop 10 times 
        for (int i = 0; i < saveHighScores.Length; i++)
        {

            // Get score off disk and store in temp variable
            tempScore = PlayerPrefs.GetInt("Score" + i);

            // Store score into array list
            //storeHighScores.Add(tempScore);

            //===================================================
            // Save into normal array
            saveHighScores[i] = tempScore;

        }// End for

    }// End loadHighScores

    public void onDeathHighScore(int newHighScore)
    {

        // Replace smallest highscore with new higher score
        // MIGHT NOT BE OVERWRITING JUST MOVING EACH NODE UP THE WAY
        //storeHighScores.Insert(0, newHighScore);

        //======================================
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

            // Store array list about as an int to a temp variable
            //var tempScore = (int)storeHighScores[i];

            //=====================================================
            // Using normal array
            var normalTemp = saveHighScores[i];

            // Save the new high scores to disk
            PlayerPrefs.SetInt("Score" + i, normalTemp);

        }


        // display new high score table
        for (int i = 0; i < saveHighScores.Length; i++)
        {

            //Debug.Log(storeHighScores[i]);

            Debug.Log(saveHighScores[i]);

        }// End for


    }// End onDeathHighScore

}// End class HighScoreTable
