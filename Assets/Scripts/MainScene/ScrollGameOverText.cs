using UnityEngine;
using System.Collections;

public class ScrollGameOverText : MonoBehaviour {

    public RectTransform gameOverTitle;

    private float gameOver = 400, centerScreen = 0;

    private float speed = 5;

    public bool isGameOver = false;

    // Use this for initialization
    void Start () {

        // Get reference to RectTransform of text
        gameOverTitle = GetComponent<RectTransform>();

        // Push text off screen
        alignText();

    }
	
	// Update is called once per frame
	void Update () {

        // isGameOver set to true when player is killed
        if (isGameOver == true && gameOver > centerScreen)
        {

            // Move text left
            gameOver -= 3;

            // Reposition game over text
            gameOverTitle.anchoredPosition = new Vector2(gameOver, 0);

        }

    }// End update

    void alignText()
    {

        // Reposition game over text
        gameOverTitle.anchoredPosition = new Vector2(gameOver, 0);

    }// alignText

}// End class ScrollGameOverText
