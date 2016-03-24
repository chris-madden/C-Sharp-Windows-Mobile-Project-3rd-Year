using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour {

    // Variables for audio
    public AudioClip enemyDeathSound;
    private AudioSource source;


    // Varibales for score
    private GameControl gc;
    private int enemyScore = 10;

	// Use this for initialization
	void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to to script
        gc = camera.GetComponent<GameControl>();

        // Get reference to to Audio source
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

    }

    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {
       
        if (coll.gameObject.tag == "goodMissile")
        {

            // When enemy is hit and destroyed add the points to the enemy score
            gc.AddScore(enemyScore);

            // If hit by missile destroy object
            Destroy(this.gameObject);

            if (enemyDeathSound)
            {

                // Play audio clip at the postiton the object is destroyed
                AudioSource.PlayClipAtPoint(enemyDeathSound, transform.position);

            }

        }// End if

    }// End OnCollisionEnter2D

}// End class DestroyEnemy
