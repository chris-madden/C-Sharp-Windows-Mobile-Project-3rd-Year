using UnityEngine;
using System.Collections;

public class MoveEnemy3 : MonoBehaviour {

    public GameObject enemyMisssile;
    public AudioClip fireMissileAudio;

    public float speed = 5f, destroyMissileTime = 1.5f, nextSpawn = 2f;
    private bool hitLeft = false;

	// Use this for initialization
	void Start () {

        // Start calling the enemyFireMissile method
        StartCoroutine(enemyFireMissile(nextSpawn));
	
	}// End Start
	
	// Update is called once per frame
	void Update () {

        // Missile shoud move up once instantiated
        transform.position += transform.up * Time.deltaTime * (speed / 2);

        // Enemy behaviour detects if left boundary was hit (Players left)
        if (transform.position.x >= -2 && hitLeft == false)
        {

            // Enemy moves to it's right (Players left)
            transform.position += transform.right * Time.deltaTime * (speed / 2);

            // If left side is hit
            if (transform.position.x < -2)
            {

                hitLeft = true;

            }// End nested if

        }// End outer if

        // Enemy behaviour detects if right boundary was hit (Players right)
        if (transform.position.x <= 2 && hitLeft == true)
        {

            // Enemy moves to its left (Players right)
            transform.position += (-transform.right) * Time.deltaTime * (speed / 2);

            if (transform.position.x > 1.85)
            {

                hitLeft = false;

            }// End nested if

        }// End outer if

    }// End Update()

    // Enemy will fire missiles
    IEnumerator enemyFireMissile(float nextSpawn)
    {

        while (true)
        {

            if (transform.position.y < 6 && transform.position.y > -1)
            {

                //Create missile on screen from center of position of ship and change it to type Rigidbody2D
                //Store the instaniated missile into a variable called missileClone
                var missileClone = Instantiate(enemyMisssile, transform.position, Quaternion.Euler(0, 0, 180));

                // Destroy the missile clone after a set number of seconds
                Destroy(missileClone, destroyMissileTime);

                if (fireMissileAudio)
                {

                    // Play shooting sound effect
                    AudioSource.PlayClipAtPoint(fireMissileAudio, transform.position);

                }

            }// End if

            yield return new WaitForSeconds(nextSpawn);

        }// End while

    }// End enemyFireMissile()

}// End class MoveEnemy3
