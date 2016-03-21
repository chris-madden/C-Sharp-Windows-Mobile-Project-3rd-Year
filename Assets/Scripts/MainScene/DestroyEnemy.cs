using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Enemy will be destroyed on impact with missile
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "goodMissile")
        {

            // If hit by missile destroy object
            Destroy(this.gameObject);
        }

    }// End 
}
