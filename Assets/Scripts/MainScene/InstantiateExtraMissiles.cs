using UnityEngine;
using System.Collections;

public class InstantiateExtraMissiles : MonoBehaviour {

    // Will reference extra missiles
    public GameObject extramissiles;

    Vector3 extraMissilePos;

    public float destroyExtraMissile = 2.3f;

    public float nextSpawn = 2f;

    // Time system
    private float startTime, elapsedTime;

    // Use this for initialization
    void Start () {

        // Use coroutine to spawn enemies every X seconds
        StartCoroutine(missileSpawn(nextSpawn));

        // Get state of time on main game start up
        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        // The timeer starts at 0 when this scene is loaded up
        elapsedTime = Time.time - startTime;
    }

    void spawnExtraMissile()
    {

        // X position can range from -3 t0 3, will always appear within camera view
        float xPos = Random.Range(-2, 2);

        // Y position of where missiles will spawn
        float yPos = 5.5f; 

        // Give enemy a new position each time it's spawned
        extraMissilePos = new Vector3(xPos, yPos, 0);

        // Spawn enemy at a random position and store in a clone
        // Enemy is rotated 180 degrees to face player
        var extraMissileClone = GameObject.Instantiate(extramissiles, extraMissilePos, Quaternion.Euler(0, 0, 90));

        // Will destroy object after certain amount of time
        Destroy(extraMissileClone, destroyExtraMissile);

    }// End spawnEnemy3

    // Used to control how quickly enemies will spawn as players score gets higher
    IEnumerator missileSpawn(float nextSpawn)
    {
        while (true)
        {

            // Less than 30 seconds
            if (elapsedTime < 60)
            {

               nextSpawn = 5f;

            }

            // Between 30 and 60 seconds
            if (elapsedTime > 60 && elapsedTime < 120)
            {

                nextSpawn = 4f;

            }

            if (elapsedTime > 120 && elapsedTime < 180)
            {

                nextSpawn = 3f;

            }

            if (elapsedTime > 180 && elapsedTime < 240)
            {

                nextSpawn = 2f;

            }

            if (elapsedTime > 240)
            {
                nextSpawn = 1.5f;
            }

            // Call method to spawn enemy at random positions
            spawnExtraMissile();

            // Wait for certain number of seconds
            yield return new WaitForSeconds(nextSpawn);
        }

    }// End enemySpawn

}// End class InstantiateExtraMissiles
