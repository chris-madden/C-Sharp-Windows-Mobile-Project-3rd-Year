using UnityEngine;
using System.Collections;

public class FireMissile : MonoBehaviour {

    public GameObject missile;

    public Transform rocketPos;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

       
	
	}

    public void fireMissile()
    {
        // Create missile on screen from center of position of ship and change it to type Rigidbody2D
        Instantiate(missile, transform.position, Quaternion.identity);
    }

}
