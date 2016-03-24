using UnityEngine;
using System.Collections;

public class MoveEnemy3 : MonoBehaviour {

    public float speed = 5;

    private bool hitLeft = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Missile shoud move up once instantiated
        transform.position += transform.up * Time.deltaTime * (speed / 2);

        // Enemy behaviour
        if (transform.position.x >= -2 && hitLeft == false)
        {

            // Enemy moves to it's right (Players left)
            transform.position += transform.right * Time.deltaTime * (speed / 2);

            // If left side is hit
            if (transform.position.x < -2)
            {

                hitLeft = true;

            }

        }

        if (transform.position.x <= 2 && hitLeft == true)
        {

            // Enemy moves to its left (Players right)
            transform.position += (-transform.right) * Time.deltaTime * (speed / 2);

            if (transform.position.x > 1.85)
            {

                hitLeft = false;

            }

        }// End if else

    }// End update

}// End class MoveEnemy3
