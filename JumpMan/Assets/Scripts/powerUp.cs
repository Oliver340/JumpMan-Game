using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

	public Rigidbody2D rb2d;

	private float powerUpSpeed = 440;



	// Use this for initialization
	void Start () {

		rb2d.AddForce (transform.right * powerUpSpeed);

		rb2d.AddForce (transform.up * powerUpSpeed);

	}
	
	// Update is called once per frame
	void Update () {

}
}
