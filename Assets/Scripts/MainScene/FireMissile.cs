using UnityEngine;
using System.Collections;

public class FireMissile : MonoBehaviour {

    // Represents the missile prefab
    public GameObject missile;

    // Get variable of type GameControl script
    private GameControl gc;

    // Audio for shooting missile
    public AudioClip fireMissileAudio;

    // Time until missile is destroyed
    public float destroyMissileTime = 2;

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

    public void fireMissile()
    {

        // If player still has missiles 
        if (GameControl.numOfMissiles != 0)
        {

            // Create missile on screen from center of position of ship and change it to type Rigidbody2D
            // Store the instaniated missile into a variable called missileClone
            var missileClone = Instantiate(missile, transform.position, Quaternion.identity);

            // Take one missile away for each shot
            gc.subtractMissiles(GameControl.numOfMissiles);

            // Destroy the missile clone after a set number of seconds
            Destroy(missileClone, destroyMissileTime);

            if (fireMissileAudio)
            {

                // Play shooting sound effect
                AudioSource.PlayClipAtPoint(fireMissileAudio, transform.position);

            }

        }// End if
           

    }// End fireMissile

}// End class FireMissile
