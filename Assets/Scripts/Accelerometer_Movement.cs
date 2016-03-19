using UnityEngine;
using System.Collections;

public class Accelerometer_Movement : MonoBehaviour {

    // Controls the speed of the ship movement
    public float speed = 5;

	// Use this for initialization
	void Start () {

        // Position ship on start up to bottom center of screen 
        transform.position = new Vector2(0, -3);

    }
	
	// Update is called once per frame
	void Update () {

        // Accelerometer control on X axis
        transform.Translate(Vector3.right * Input.acceleration.x / speed, Space.World);

    }
}
