using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class jumpMan : MonoBehaviour {

	public bool grounded;

	private Rigidbody2D rb2d;

	public float velocity = 20;

	public float jumpVelocity = 750;

	public float fallVelocity = -50;

	public int health = 3;

	public GameObject human;

	public Text healthText;

	public GameObject bullet;

	Vector3 pos = new Vector3 (0, 0, 0);

	Vector3 bulletPos = new Vector3 (1, 0, 0);

	public float nextFire = -1;

	public Animation anim;

	public string Trigger;

	public GameObject spikes;

	public GameObject spikes2;

	public GameObject spikes3;

	public GameObject button;

	public GameObject button2;

	public GameObject jetpack;

	public GameObject jetpackRockets;

	public Text timeText;

	public bool pause;

	public float startTime;

	public float elapsedTime;

	public GameObject LOGO;

	public GameObject boss;

	public AudioSource bulletSound;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

		nextFire = Time.time;

		anim = GetComponent<Animation>();
		anim.Stop();


		button2.SetActive(false);
	
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Level 1")){
			startTime = Time.time;
		}

		bulletSound = GameObject.FindObjectOfType<AudioSource>();
	
	}
		
	
	// Update is called once per frame
	void Update () {
		

		elapsedTime = Time.time - startTime;

		healthText.text = "Lives: " + health;

		timeText.text = "" + elapsedTime;





		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded == true && pause == false) {

			rb2d.AddForce (transform.up * jumpVelocity);

		}




		if (Input.GetKey (KeyCode.LeftArrow) && pause == false) {

			rb2d.AddForce (transform.right * velocity);
			transform.rotation = Quaternion.Euler (0, 180, 0);
			GetComponent<Animator>().SetTrigger("Trigger");
		}

		if (Input.GetKey (KeyCode.RightArrow) && pause == false) {

			rb2d.AddForce (transform.right * velocity);
			transform.rotation = Quaternion.Euler (0, 0, 0);
			GetComponent<Animator>().SetTrigger("Trigger");
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {GetComponent<Animator>().SetTrigger("Trigger");}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {GetComponent<Animator>().SetTrigger("Trigger");}


		if (Time.time >= nextFire) {

			if (Input.GetKey (KeyCode.Space) && transform.rotation == Quaternion.Euler (0, 0, 0) && pause == false) {
			
				GameObject instance = Instantiate (bullet, transform.position + bulletPos, transform.rotation);
				nextFire = Time.time + 1;
				bulletSound.Play();
				Debug.Log("SDFDSF");
		

			} else if (Input.GetKey (KeyCode.Space) && pause == false) {
			
				GameObject instance = Instantiate (bullet, transform.position - bulletPos, transform.rotation);
				nextFire = Time.time + 1;
				bulletSound.Play();
				Debug.Log("SDFDSF");
			}

		}

		if (Input.GetKeyDown (KeyCode.P)){
			if (button2.activeSelf){
				button2.SetActive(false);
				Time.timeScale = 1;
				pause = false;
			}
			else{
				button2.SetActive(true);
				Time.timeScale = 0;
				pause = true;
			}
		
		}

		if (Input.GetKeyDown (KeyCode.O)){

		
			if (Time.timeScale == 1){
				Time.timeScale = 0.5f;
			}
			else{
				Time.timeScale = 1;
			}
			if (button2.activeSelf){
				Time.timeScale = 0;
			}

		}
	
	
		if (jetpack.activeSelf && Input.GetKey (KeyCode.UpArrow) && pause == false){
			rb2d.AddForce (transform.up * 35);
			jetpackRockets.SetActive(true);
		} else {jetpackRockets.SetActive(false);}


		if (Input.GetKey (KeyCode.DownArrow) && pause == false){
			rb2d.AddForce (transform.up * fallVelocity);
		}

		if (Time.timeScale == 0){
			pause = true;
		}




	
			

		if (health <= 0) {
			SceneManager.LoadScene ("GameOver");
		}

		if (health == 2) {
			healthText.color = Color.yellow;
		}

		if (health == 1) {
			healthText.color = Color.red;
		}

		if (health >= 3) {
			healthText.color = Color.green;
		}

	
		if (boss.activeSelf){
			LOGO.SetActive (false);
		}
		else {
			LOGO.SetActive (true);
		}
	
	
		

	}




	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "ground" || other.gameObject.tag == "platform" || other.gameObject.tag == "water") {

			grounded = true;
		} 

		if (other.gameObject.tag == "enemy" || other.gameObject.tag == "outOfBounds" || other.gameObject.tag == "shooterEnemy" || other.gameObject.tag == "enemyBullet" || other.gameObject.tag == "spikes" || other.gameObject.tag == "boss" || other.gameObject.tag == "eyeBullet") {

			transform.position = new Vector2 (-48.4f, 2f);
			rb2d.velocity = Vector3.zero;
			health -= 1;

			if (health == 2){
				spikes.SetActive(false);
				spikes2.SetActive(true);
			}
			if (health == 1){
				spikes2.SetActive(false);
				spikes3.SetActive(true);
			}
		

		}
			 



			if (other.gameObject.tag == "powerUp") {

				health += 1;
				other.gameObject.SetActive (false);
			}

		if (other.gameObject.tag == "LOGO") {

			health += 99999999;
			transform.position = new Vector2 (-48.4f, -3.451999f);
			button.SetActive(true);
			spikes.SetActive(false);
			spikes2.SetActive(false);
			spikes3.SetActive(false);
			other.gameObject.SetActive(false);
			jetpack.SetActive(true);
			Time.timeScale = 0;
		}

		if (other.gameObject.tag == "sprite"){
			spikes.SetActive(false);
			spikes2.SetActive(false);
			spikes3.SetActive(false);
			jetpack.SetActive(true);
			other.gameObject.SetActive(false);
		}

			

	}

		void OnCollisionExit2D (Collision2D other)
	{
		if (other.gameObject.tag == "ground" || other.gameObject.tag == "platform" || other.gameObject.tag == "water") {

			grounded = false;
		}

	



	}

		void OnCollisionStay2D (Collision2D other){
		if (other.gameObject.tag == "ground" || other.gameObject.tag == "platform" || other.gameObject.tag == "water")
			{
				grounded = true;
			}
			if (other.gameObject.tag == null){
				grounded = false;
			}
		}






	
	









}
