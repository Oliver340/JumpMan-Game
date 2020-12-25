using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

	public float enemySpeed = 0;

	public Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {

		rb2D.AddForce (transform.right * enemySpeed);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{


		if (other.gameObject.tag == "human") {


		}




	}


}
