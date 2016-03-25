using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scroll_Title : MonoBehaviour {

    private RectTransform title;

    private float titlePos = 200;

    private float screenCenter = -150;

    public float speed = 2;

    // Use this for initialization
    void Start () {

        // Get reference to the Game titles Transform
        title = GetComponent<RectTransform>();

        // Move the title above the screen
        title.anchoredPosition = new Vector2(0, titlePos);

    }
	
	// Update is called once per frame
	void Update () {

        // Subtract from titlePos to move title down screen
        titlePos -= speed;

        // If the title hasn't reached the center of the screen
        if (titlePos > screenCenter)
        {
            // Move the title down
            title.anchoredPosition = new Vector2(0, titlePos);
        }

    }// End update

}// End class Scroll_Title
