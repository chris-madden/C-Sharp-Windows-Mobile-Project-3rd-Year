using UnityEngine;
using System.Collections;

public class DetroyEnemyMissile : MonoBehaviour {

    // Variables for audio
    public AudioClip enemyDeathSound;

    public GameObject explosionSmall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {

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

            }

        }// End if

    }// End OnCollisionEnter2D
}
