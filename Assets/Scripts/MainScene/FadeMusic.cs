using UnityEngine;
using System.Collections;

public class FadeMusic : MonoBehaviour {

    public AudioSource backgroundMusic;

    private float musicVolume = 0.1f;
    public bool isGameOver = false;

	// Use this for initialization
	void Start () {

        // Set background music volume
        backgroundMusic.volume = musicVolume;
        
	}// End Start()
	
	// Update is called once per frame
	void Update () {

        // If player has been killed
        if(isGameOver == true)
        {

            // Fade the background music while the game over text scrolls
            backgroundMusic.volume -= musicVolume * Time.deltaTime / 2;

        }// End if

	}// End Update()

}// End class FadeMusic
