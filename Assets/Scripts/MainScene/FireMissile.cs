using UnityEngine;
using System.Collections;

public class FireMissile : MonoBehaviour {

    // Represents the missile prefab
    public GameObject missile;

    // Time until missile is destroyed
    public float destroyMissile = 2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

       

    }

    public void fireMissile()
    {
        // Create missile on screen from center of position of ship and change it to type Rigidbody2D
        // Store the instaniated missile into a variable called missileClone
        var missileClone = Instantiate(missile, transform.position, Quaternion.identity);

        // Destroy the missile clone after a set number of seconds
        Destroy(missileClone, destroyMissile);

    }// End fireMissile

}
