using UnityEngine;
using System.Collections;

public class MoveExtraMissile : MonoBehaviour {

    public float speed = 5;

	// Update is called once per frame
	void Update () {

        // Extra Missile moves down towards player  
        transform.position += (-transform.right) * Time.deltaTime * speed;

    }// End Update()

}// End MoveExtraMissile
