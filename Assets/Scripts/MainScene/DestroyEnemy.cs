using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour {

    private GameControl gc;
    private int enemyScore = 10;

	// Use this for initialization
	void Start () {

        // Find camera with script on it
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get reference to to script
        gc = camera.GetComponent<GameControl>();

      
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

        }

    }// End 
}
