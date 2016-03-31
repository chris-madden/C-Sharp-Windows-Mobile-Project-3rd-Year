using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserIsHit : MonoBehaviour {

    private ScrollGameOverText sTxt;
    private FadeMusic fm;
    public GameObject explosion;
    public GameControl gc;
    public AudioClip playerDeathSound;

    // Use this for initialization
    void Start () {

        // Find object with has the script ScrollGameOverText
        GameObject textScroll = GameObject.FindGameObjectWithTag("Finish");

        // Get a reference to script ScrollGameOverText
        sTxt = textScroll.GetComponent<ScrollGameOverText>();

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to script FadeMusic
        fm = camera.GetComponent<FadeMusic>();

        // Get reference to script GameControl
        gc = camera.GetComponent<GameControl>();

    }// End Start()
	
    // Triggers end of current session
    void OnCollisionEnter2D(Collision2D coll)
    {

        // If player collides with enemy
        if (coll.gameObject.tag == "enemy")
        {

            // Clone the explosion object at the position where the enemy is hit with the missile
            GameObject cloneExplosion = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);

            // Destroy the explosion after half a second
            Destroy(cloneExplosion, 0.05f);

            // Remove ship from scene
            Destroy(this.gameObject);

            if (playerDeathSound)
            {

                // Play audio clip at the postiton the object is destroyed
                AudioSource.PlayClipAtPoint(playerDeathSound, transform.position);

            }// End nested if

            // Tell ScrollGameOverText script that game is over
            isGameOver();

        }// End if

    }// End OnCollisionEnter2D() 
 
    // Set variables to a different state if game is over
    void isGameOver()
    {

        // Set to true to start txt scrolling
        sTxt.isGameOver = true;

        fm.isGameOver = true;

        gc.isDead = true;

    }// End isGameOver()

}// End class UserIsHit
