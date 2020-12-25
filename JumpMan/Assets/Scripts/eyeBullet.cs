using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class eyeBullet : MonoBehaviour
{
	private float bulletSpeed = 5;

	public Rigidbody2D rb2d;

	public float time;

	private Vector3 humanPos;

	private GameObject human;











	// Use this for initialization
	void Start () {

		human = GameObject.Find("human");

		time = 6;
	}

	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;
		if (time <= 0) {
			gameObject.SetActive (false);
			time = 6;
		
		}

		humanPos = new Vector3(human.transform.position.x, human.transform.position.y, human.transform.position.z);
		transform.position = Vector3.MoveTowards(transform.position, humanPos, bulletSpeed * Time.deltaTime);



		}



	void OnCollisionEnter2D (Collision2D other){
		
		if (other.gameObject.tag == "human") {
		gameObject.SetActive (false);
			time = 6;
		}


	}
}
