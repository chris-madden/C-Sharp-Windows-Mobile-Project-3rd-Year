using UnityEngine;
using System.Collections;

public class MoveEnemy3 : MonoBehaviour {

    public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Missile shoud move up once instantiated
        transform.position += transform.up * Time.deltaTime * speed;

    }
}
