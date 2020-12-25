using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class spikeWall : MonoBehaviour {


	public Rigidbody2D rb2d;

	public float spikeVelocity = 100000000;






	// Use this for initialization
	void Start () {
		rb2d.AddForce (transform.right * spikeVelocity);
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnCollisionEnter2D (Collision2D other){



	}

}
