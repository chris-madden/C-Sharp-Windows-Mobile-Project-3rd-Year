using UnityEngine;
using System.Collections;

public class ErrorGUI : MonoBehaviour {

    void OnGUI()
    {
        // Create a custom style for the error message button
        GUIStyle customButton = new GUIStyle("button");
        customButton.fontSize = 16;
        customButton.fontStyle = FontStyle.Bold;

        GUI.backgroundColor = Color.black;

        // Draw error message button to screen
        if (GUI.Button(new Rect(0, Screen.height / 2.5f, Screen.width, 100), "No Accelerometer Present\nPlease download with device which has one", customButton))
        {
            // Disable this screen when button is pressed
            this.enabled = false;
        }

    }// End OnGUI()

}// End class ErrorGUI
