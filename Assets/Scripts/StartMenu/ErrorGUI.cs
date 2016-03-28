using UnityEngine;
using System.Collections;

public class ErrorGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {

        if (GUI.Button(new Rect(50, Screen.height / 2.5f, 300, 100), "No Accelerometer Present\nPlease download with device which has one"))
        {
            this.enabled = false;
        }

    }
}
