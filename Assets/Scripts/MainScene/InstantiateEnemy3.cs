using UnityEngine;
using System.Collections;

public class InstantiateEnemy3 : MonoBehaviour {

    // Will reference enemy3
    public GameObject enemy3;

    // Stores random values for enemy spawning posiitons
    Vector3 enemyPos;

    public float destroyEnemy = 10;

    // Time to wait until next enemy is spawned
    public float spawnTime = 1f;

    public static float nextSpawn = 2f;

    // Time system
    private float startTime, elapsedTime;

    // Use this for initialization
    void Start () {

        // Use coroutine to spawn enemies every X seconds
        StartCoroutine(enemySpawn(nextSpawn));

        // Get state of time on main game start up
        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {

        // The timeer starts at 0 when this scene is loaded up
        elapsedTime = Time.time - startTime;

    }

    void spawnEnemy3()
    {

        // X position can range from -3 t0 3, will always appear within camera view
        float xPos = Random.Range(-2, 2);

        // Y position can range from 4 to 7, will instantiate off screen but not too far
        float yPos = Random.Range(6, 8);

        // Give enemy a new position each time it's spawned
        enemyPos = new Vector3(xPos, yPos, 0);

        // Spawn enemy at a random position and store in a clone
        // Enemy is rotated 180 degrees to face player
        var enemy3Clone = GameObject.Instantiate(enemy3, enemyPos, Quaternion.Euler(0, 0, 180));

        // Will destroy object after certain amount of time
        Destroy(enemy3Clone, destroyEnemy);

    }// End spawnEnemy3

    // Used to control how quickly enemies will spawn as players score gets higher
    IEnumerator enemySpawn(float nextSpawn)
    {
        while (true)
        {

            // Less than 30 seconds
            if (elapsedTime < 60)
            {

                nextSpawn = 1.5f;

            }

            // Between 30 and 60 seconds
            if (elapsedTime > 60 && elapsedTime < 120)
            {

                nextSpawn = 1.25f;

            }

            if (elapsedTime > 120 && elapsedTime < 180)
            {

                nextSpawn = 1f;

            }

            if (elapsedTime > 180 && elapsedTime < 240)
            {

                nextSpawn = 0.8f;

            }

            if (elapsedTime > 240)
            {
                nextSpawn = 0.6f;
            }

            // Call method to spawn enemy at random positions
            spawnEnemy3();

            // Wait for certain number of seconds
            yield return new WaitForSeconds(nextSpawn);
        }

    }// End enemySpawn

}// End class InstantiateEnemy3
