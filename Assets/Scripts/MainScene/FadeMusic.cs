using UnityEngine;
using System.Collections;

public class FadeMusic : MonoBehaviour {

    public AudioSource backgroundMusic;

    private float musicVolume = 0.5f;

    public bool isGameOver = false;

  
	// Use this for initialization
	void Start () {

        backgroundMusic.volume = musicVolume;
        

	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(musicVolume);

        if(isGameOver == true)
        {

            backgroundMusic.volume -= musicVolume * Time.deltaTime / 2;

            Debug.Log(backgroundMusic.volume);

        }

       
	
	}
}
