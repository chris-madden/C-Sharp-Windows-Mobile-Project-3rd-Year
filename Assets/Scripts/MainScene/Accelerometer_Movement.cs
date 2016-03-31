using UnityEngine;
using System.Collections;

public class Accelerometer_Movement : MonoBehaviour {

    // Controls the speed of the ship movement
    public float speed = 5;

    // Will contain the size of the ship
    Vector3 shipSize;

    // Use this for initialization
    void Start () {

        // Position ship on start up to bottom center of screen 
        transform.position = new Vector2(0, -3);

        // Get the size of the ship
        shipSize = GetComponent<Renderer>().bounds.size;

    }// End Start
	
	// Update is called once per frame
	void Update () {

        // Get the Z value
        var distance = (transform.position.z - Camera.main.transform.position.z);

        // Store ships position
        var shipPos = transform.position;

        // Store positon of left side of screen relative to the cameras view
        var leftScreen = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + (shipSize.x / (float)1.5);

        // Store positon of right side of screen relative to the cameras view
        var rightScreen = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - (shipSize.x / (float)1.5);

        // Clamp the ships position on the x axis so it can't go off screen
        transform.position = new Vector3(Mathf.Clamp(shipPos.x, leftScreen, rightScreen), shipPos.y, shipPos.z);

        //Accelerometer movement on x axis.
        transform.Translate(Vector3.right * Input.acceleration.x, Space.World);


    }// End update

}// End class Accelerometer_Movement
