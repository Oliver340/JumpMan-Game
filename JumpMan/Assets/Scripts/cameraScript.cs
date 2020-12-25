using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = GameObject.FindGameObjectWithTag ("human").transform.position;
		GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3 (playerPos.x,playerPos.y,playerPos.z -10);
	}
}
