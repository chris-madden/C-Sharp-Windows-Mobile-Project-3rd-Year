using UnityEngine;
using System.Collections;

public class MoveMissile : MonoBehaviour {

    // Speed of the missile
    public float speed = 5;

	// Update is called once per frame
	void Update () {

        // Missile shoud move up once instantiated
        transform.position += transform.up * Time.deltaTime * speed;

        // If missile goes off screen then destroy it
        if (transform.position.y > 5)
        {

            Destroy(this.gameObject);

        }// End if
	
	}// End Update()

    void OnCollisionEnter2D(Collision2D coll)
    {
        // If there's a collison with an obeject who has the tag enemy
        if (coll.gameObject.tag == "enemy")
        {
           
            Destroy(this.gameObject);

        }// End if

    }// End OnCollisionEnter2D()

}// End class MoveMissile

