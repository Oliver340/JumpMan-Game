using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {

	public GameObject instructions;




	// Use this for initialization
	void Start () {

	
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void LoadScene1(int SampleScene)  {
		SceneManager.LoadScene ("Level 1");
		Time.timeScale = 1;
	}

	public void LoadScene2(int SampleScene)  {
		SceneManager.LoadScene ("Level 2");
		Time.timeScale = 1;
	}

	public void LoadScene3(int SampleScene)  {
		SceneManager.LoadScene ("Level 3");
		Time.timeScale = 1;
	}

	public void Instructions()  {
		
		if (instructions.activeSelf){
			instructions.SetActive(false);
		}
		else{
			instructions.SetActive(true);
		}

	}

}
