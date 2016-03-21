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
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
            Debug.Log("Missile hit enemy!");

            Destroy(this.gameObject);
        }
            

    }
}
