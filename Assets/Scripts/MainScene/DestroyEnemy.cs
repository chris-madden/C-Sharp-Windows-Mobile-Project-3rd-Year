using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour {

    // Variables for audio
    public AudioClip enemyDeathSound;
  
    // Will create explosion when enemy is hit
    public GameObject explosion;

    // Varibales for score
    private GameControl gc;
    private int enemyScore = 10;

	// Use this for initialization
	void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to to script GameControl
        gc = camera.GetComponent<GameControl>();

    }// End Start()
	
    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {
        // If there's a collision with an object that has the tag goodMissile
        if (coll.gameObject.tag == "goodMissile")
        {

            // When enemy is hit and destroyed add the points to the enemy score
            gc.AddScore(enemyScore);

            // If hit by missile destroy object
            Destroy(this.gameObject);

            // Clone the explosion object at the position where the enemy is hit with the missile
            GameObject cloneExplosion = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);

            // Destroy the explosion after half a second
            Destroy(cloneExplosion, 0.05f);

            if (enemyDeathSound)
            {

                // Play audio clip at the postiton the object is destroyed
                AudioSource.PlayClipAtPoint(enemyDeathSound, transform.position);

            }// End nested if

        }// End outer if

    }// End OnCollisionEnter2D

}// End class DestroyEnemy
