using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

	public GameObject powerUp;

	Vector3 pos = new Vector3 (0, 1, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "human") {

			GameObject instance = Instantiate (powerUp, transform.position + pos, transform.rotation);
			gameObject.SetActive (false);
		}

	}



}
