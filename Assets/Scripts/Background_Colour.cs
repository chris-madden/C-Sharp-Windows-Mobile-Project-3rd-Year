using UnityEngine;
using System.Collections;

public class Background_Colour : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Renderer background;

        background = GetComponent<Renderer>();

        background.material.color = Color.black;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
