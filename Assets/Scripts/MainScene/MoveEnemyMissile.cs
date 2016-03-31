using UnityEngine;
using System.Collections;

public class MoveEnemyMissile : MonoBehaviour {

    public float speed = 5;
	
	// Update is called once per frame
	void Update () {

        // Extra Missile moves down towards player  
        transform.position += transform.up * Time.deltaTime * speed;

    }// End update()

}// End class MoveEnemyMissile
