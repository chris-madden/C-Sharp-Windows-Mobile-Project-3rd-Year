using UnityEngine;
using System.Collections;

public class CheckForAccelerometer : MonoBehaviour {

    private ErrorGUI eg;
 
	// Use this for initialization
	void Start () {

        // Look for camera object which is holding script ErrorGUI
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        // Get a reference to the ErrorGUI script
        eg = camera.GetComponent<ErrorGUI>();

        // Check if device has an accelerometer
        if (SystemInfo.supportsAccelerometer)
        {
            // Leave message script disabled
            eg.enabled = false;
        }
        else
        {
            // Turn on message script if no accelerometer present
            eg.enabled = true;
        }// End if/else

    }// End Start()

}// End class CheckForAccelerometer
