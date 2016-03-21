using UnityEngine;
using System.Collections;

public class InstantiateEnemy3 : MonoBehaviour {

    // Will reference enemy3
    public GameObject enemy3;

    Vector3 enemyPos;

    // Time to wait until next enemy is spawned
    public float spawnTime = 1;

	// Use this for initialization
	void Start () {

        InvokeRepeating("spawnEnemy3", spawnTime, spawnTime);

        enemyPos = new Vector3(2, 2, 0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnEnemy3()
    {

        // Spawn enemy at a certain position and store in a clone
        var enemy3Clone = GameObject.Instantiate(enemy3, enemyPos, Quaternion.identity);

        // Will destroy object if it leaves camera view

    }// End spawnEnemy3
}
