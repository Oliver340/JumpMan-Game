using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other){
		
		if (other.gameObject.tag == "human" && gameObject.tag == "flag1") {
			SceneManager.LoadScene ("Level 1.5");
		}

		if (other.gameObject.tag == "human" && gameObject.tag == "flag2") {
			SceneManager.LoadScene ("Level 2.5");
		}

	}
}
