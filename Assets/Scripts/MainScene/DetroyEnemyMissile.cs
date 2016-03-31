using UnityEngine;
using System.Collections;

public class DetroyEnemyMissile : MonoBehaviour {

    // Variables for audio
    public AudioClip enemyDeathSound;
    public GameObject explosionSmall;

    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        // If there's a collision with a game object called goodMissile
        if (coll.gameObject.tag == "goodMissile")
        {

            // If hit by missile destroy object
            Destroy(this.gameObject);

            // Clone the explosion object at the position where the enemy is hit with the missile
            GameObject cloneExplosion = (GameObject)Instantiate(explosionSmall, transform.position, Quaternion.identity);

            // Destroy the explosion after half a second
            Destroy(cloneExplosion, 0.05f);

            if (enemyDeathSound)
            {

                // Play audio clip at the postiton the object is destroyed
                AudioSource.PlayClipAtPoint(enemyDeathSound, transform.position);

            }// End nested if

        }// End outer if

    }// End OnCollisionEnter2D()

}// End class DetroyEnemyMissile
