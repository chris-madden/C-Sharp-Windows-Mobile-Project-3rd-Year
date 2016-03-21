using UnityEngine;
using System.Collections;

public class InstantiateEnemy3 : MonoBehaviour {

    // Will reference enemy3
    public GameObject enemy3;

    // Stores random values for enemy spawning posiitons
    Vector3 enemyPos;

    public float destroyEnemy = 10;

    // Time to wait until next enemy is spawned
    public float spawnTime = 10f;

    public float nextSpawn = 2f;

    // Use this for initialization
    void Start () {

        // Keep spawning enemy 
        InvokeRepeating("spawnEnemy3", spawnTime, nextSpawn);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnEnemy3()
    {

        // X position can range from -4 t0 4, will always appear within camera view
        float xPos = Random.Range(-4, 4);

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

}
