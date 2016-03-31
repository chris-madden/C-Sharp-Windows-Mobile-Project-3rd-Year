using UnityEngine;
using System.Collections;

public class ShareToMedia : MonoBehaviour {

    // Variables for storing message information
    private int highscore;
    private string message = "Hey! I just played Shoot Die Repeat, My high score is ";
    private string messagePart2 = ". Try beat it!";

    // Use this for initialization
    void Start () {

        // Initialise variables
        highscore = PlayerPrefs.GetInt("Score9");
        message += highscore.ToString();
        message += messagePart2;

    }// End Start()
	
    // Share high score to Twitter
    public void shareToTwitter()
    {

        // Send message to twitter
        Application.OpenURL("https://twitter.com/intent/tweet?text=" + message);

    }// End shareToTwitter()

}// End class ShareToMedia
