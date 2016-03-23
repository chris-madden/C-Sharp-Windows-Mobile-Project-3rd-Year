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

    }// End Start
	
	// Update is called once per frame
	void Update () {
	
	}

    void displayTopScores()
    {

        // Get scores from array and display them
        Score9.text = "1. " + HighScoreTable.saveHighScores[9];
        Score8.text = "2. " + HighScoreTable.saveHighScores[8];
        Score7.text = "3. " + HighScoreTable.saveHighScores[7];
        Score6.text = "4. " + HighScoreTable.saveHighScores[6];
        Score5.text = "5. " + HighScoreTable.saveHighScores[5];
        Score4.text = "6. " + HighScoreTable.saveHighScores[4];
        Score3.text = "7. " + HighScoreTable.saveHighScores[3];
        Score2.text = "8. " + HighScoreTable.saveHighScores[2];
        Score1.text = "9. " + HighScoreTable.saveHighScores[1];
        Score0.text = "10. " + HighScoreTable.saveHighScores[0];

    }// End displayTopScores

}// End class ShowHighScores
