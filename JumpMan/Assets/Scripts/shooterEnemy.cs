using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterEnemy : MonoBehaviour {

	Vector3 bulletPos = new Vector3 (2, 2, 0);

	public GameObject enemyBullet;

	public float nextFire = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time >= nextFire) {
			
				GameObject instance = Instantiate (enemyBullet, transform.position - bulletPos, transform.rotation);
				nextFire = Time.time + 2;
			}
		}
		
	}

