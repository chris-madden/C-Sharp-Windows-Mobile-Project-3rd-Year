using UnityEngine;
using System.Collections;

public class Background_Colour : MonoBehaviour {

    public Renderer background;

	// Use this for initialization
	void Start () {

        background = GetComponent<Renderer>();

        background.material.color = Color.black;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void printOut()
    {

        Debug.Log("Button has executed");

    }

    public void yellowBackground()
    {
        background = GetComponent<Renderer>();

        background.material.color = Color.yellow;
    }
}
