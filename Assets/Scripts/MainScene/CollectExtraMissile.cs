using UnityEngine;
using System.Collections;

public class CollectExtraMissile : MonoBehaviour {

    private GameControl gc;
    public AudioClip collectMissile;
    public int extraMissiles = 5;

    // Use this for initialization
    void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to to script GameControl
        gc = camera.GetComponent<GameControl>();

    }

    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {

            // When enemy is hit and destroyed add the points to the enemy score
            gc.addMissiles(extraMissiles);

            // If hit by missile destroy object
            Destroy(this.gameObject);

            if (collectMissile)
            {

                // Play Audio
                AudioSource.PlayClipAtPoint(collectMissile, transform.position);

            }// End nested if

        }// End outer if

    }// End OnCollisionEnter2D()

}// End CollectExtraMissile
