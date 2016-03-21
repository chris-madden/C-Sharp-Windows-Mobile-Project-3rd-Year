using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UserIsHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {

            // Pause game if player is hit
            //Time.timeScale = 0;

            SceneManager.LoadScene("GameOverScreen");
        }

    }// End 
}
