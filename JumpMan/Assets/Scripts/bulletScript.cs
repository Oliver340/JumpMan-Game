using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	public float bulletSpeed = 1000;

	public Rigidbody2D rb2d;

	public float time = 1.5f;




	// Use this for initialization
	void Start () {

		rb2d.AddForce (transform.right * bulletSpeed);


	}
	
	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;
		if (time <= 0) {
			gameObject.SetActive (false);

		
		}




}
		
	void OnCollisionEnter2D (Collision2D other){

		gameObject.SetActive (false);

		if (other.gameObject.tag == "enemy" || other.gameObject.tag == "shooterEnemy") {
			other.gameObject.SetActive (false);
		}

		if (other.gameObject.tag == "boss") {
			
		}



	}

}