using UnityEngine;
using System.Collections;

public class MoveMissile : MonoBehaviour {

    // Speed of the missile
    public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Missile shoud move up once instantiated
        transform.position += transform.up * Time.deltaTime * speed;

        // If missile goes off screen then destroy it
        if (transform.position.y > 5)
        {

            Destroy(this.gameObject);

        }
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
           
            Destroy(this.gameObject);
        }
            

    }
}
