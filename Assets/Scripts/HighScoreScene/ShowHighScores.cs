using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowHighScores : MonoBehaviour {

    public Text Score9, Score8, Score7, Score6, Score5, Score4, Score3, Score2, Score1, Score0;
    private HighScoreTable hst;

	// Use this for initialization
	void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to the script HighScoreTable
        hst = camera.GetComponent<HighScoreTable>();

        // Read scores off disk
        hst.loadHighScores();

        // Display score in GUI
        displayTopScores();

    }// End Start()
	
    void displayTopScores()
    {

        // Get scores from array and display them
        Score9.text = " " + HighScoreTable.saveHighScores[9];
        Score8.text = " " + HighScoreTable.saveHighScores[8];
        Score7.text = " " + HighScoreTable.saveHighScores[7];
        Score6.text = " " + HighScoreTable.saveHighScores[6];
        Score5.text = " " + HighScoreTable.saveHighScores[5];
        Score4.text = " " + HighScoreTable.saveHighScores[4];
        Score3.text = " " + HighScoreTable.saveHighScores[3];
        Score2.text = " " + HighScoreTable.saveHighScores[2];
        Score1.text = " " + HighScoreTable.saveHighScores[1];
        Score0.text = " " + HighScoreTable.saveHighScores[0];

    }// End displayTopScores()

}// End class ShowHighScores
