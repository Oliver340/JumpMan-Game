using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour {

	public float bulletSpeed = -800;

	public Rigidbody2D rb2d;

	public float time = 2;

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



	}

}
