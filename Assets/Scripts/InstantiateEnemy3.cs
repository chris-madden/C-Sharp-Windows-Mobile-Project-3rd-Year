using UnityEngine;
using System.Collections;

public class InstantiateEnemy3 : MonoBehaviour {

    // Will reference enemy3
    public GameObject enemy3;

    Vector3 enemyPos;

    public float destroyEnemy = 10;

    // Time to wait until next enemy is spawned
    public float spawnTime = 10f;

	// Use this for initialization
	void Start () {

        // Wait 20 seconds for new enemy to spawn
        InvokeRepeating("spawnEnemy3", spawnTime, 20f);

        enemyPos = new Vector3(0, 2, 0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnEnemy3()
    {
       
        // Spawn enemy at a certain position and store in a clone
        var enemy3Clone = GameObject.Instantiate(enemy3, enemyPos, Quaternion.identity);

        // Will destroy object after certain amount of time
        Destroy(enemy3Clone, destroyEnemy);

    }// End spawnEnemy3

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "goodMissile")
        {

            // If hit by missile destroy object
            Destroy(GameObject.Find("enemy"));
        }

    }// End 


}
