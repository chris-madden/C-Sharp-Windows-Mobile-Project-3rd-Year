using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scroll_Credits : MonoBehaviour {

    private RectTransform credits;

    public Text creditsText;

    private float creditPos = -150;

    private float speed = 2;

    private float stopScrolling = 1800; 

    // Use this for initialization
    void Start () {

        // Get reference to the Game titles Transform
        credits = GetComponent<RectTransform>();

        // Move the title above the screen
        credits.anchoredPosition = new Vector2(0, creditPos);

    }
	
	// Update is called once per frame
	void Update () {

        // Subtract from titlePos to move title down screen
        creditPos += speed;

        // If the title hasn't reached the center of the screen
        if (creditPos < stopScrolling)
        {
            // Move the title down
            credits.anchoredPosition = new Vector2(0, creditPos);
        }

    }
}
