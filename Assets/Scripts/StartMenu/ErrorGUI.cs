using UnityEngine;
using System.Collections;

public class ErrorGUI : MonoBehaviour {

    bool buttonClicked = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {


        GUIStyle customButton = new GUIStyle("button");
        customButton.fontSize = 16;
        customButton.fontStyle = FontStyle.Bold;

        GUI.backgroundColor = Color.black;

        if (GUI.Button(new Rect(0, Screen.height / 2.5f, Screen.width, 100), "No Accelerometer Present\nPlease download with device which has one", customButton))
        {
            this.enabled = false;
        }

    }// End OnGUI()

}// End class ErrorGUI
