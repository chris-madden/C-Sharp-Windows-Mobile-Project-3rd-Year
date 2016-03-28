using UnityEngine;
using System.Collections;

public class CheckForAccelerometer : MonoBehaviour {

    private ErrorGUI eg;
 
	// Use this for initialization
	void Start () {

        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        eg = camera.GetComponent<ErrorGUI>();

        // Check if device has an accelerometer
        if (SystemInfo.supportsAccelerometer)
        {
            // Leave message script disabled
            eg.enabled = false;
        }
        else
        {

            Debug.Log("No Accelerometer available");

            // Turn on message script if no accelerometer present
            eg.enabled = true;

        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

}// End class CheckForAccelerometer
