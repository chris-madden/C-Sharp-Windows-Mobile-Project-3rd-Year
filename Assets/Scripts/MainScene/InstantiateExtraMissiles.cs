using UnityEngine;
using System.Collections;

public class InstantiateExtraMissiles : MonoBehaviour {

    // Will reference extra missiles
    public GameObject extramissiles;

    Vector3 extraMissilePos;

    public float destroyExtraMissile = 5;

    // Time to wait until next missile is spawned
    public float spawnTime = 10f;

    public float nextSpawn = 5f;

    // Use this for initialization
    void Start () {

        // Keep spawning missiles 
        InvokeRepeating("spawnExtraMissile", spawnTime, nextSpawn);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnExtraMissile()
    {

        // X position can range from -3 t0 3, will always appear within camera view
        float xPos = Random.Range(-2, 2);

        // Y position can range from 4 to 7, will instantiate off screen but not too far
        float yPos = Random.Range(6, 8);

        // Give enemy a new position each time it's spawned
        extraMissilePos = new Vector3(xPos, yPos, 0);

        // Spawn enemy at a random position and store in a clone
        // Enemy is rotated 180 degrees to face player
        var extraMissileClone = GameObject.Instantiate(extramissiles, extraMissilePos, Quaternion.Euler(0, 0, 90));

        // Will destroy object after certain amount of time
        Destroy(extraMissileClone, destroyExtraMissile);

    }// End spawnEnemy3
}
