using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour
{

	public GameObject healthBar0;

	public GameObject healthBar1;

	public GameObject healthBar2;

	public GameObject healthBar3;

	public GameObject healthBar4;

	public GameObject healthBar5;

	public GameObject healthBar6;

	public GameObject healthBar7;

	public GameObject healthBar8;

	public GameObject healthBar9;

	public GameObject healthBar10;

	public GameObject spikes;

	public GameObject spikes2;

	public GameObject spikes3;

	public GameObject boss;

	private Vector3 wayPointPos1;

	private GameObject wayPoint1;

	private Vector3 wayPointPos2;

	private GameObject wayPoint2;

	private Vector3 wayPointPos3;

	private GameObject wayPoint3;

	private float speed = 15;

	public float timer = 10f;

	public int bossHealth = 10;

	Vector3 bulletPos = new Vector3 (0, 0, 0);

	public GameObject eyeBullet;

	public float nextFire = -1;

	public bool moveTo1;

	public bool moveTo2;

	public bool moveTo3;


    // Start is called before the first frame update
    void Start()
    {
		wayPoint1 = GameObject.Find("waypoint1");

		wayPoint2 = GameObject.Find("waypoint2");

		wayPoint3 = GameObject.Find("waypoint3");
    }


    // Update is called once per frame
    void Update()
    {
		wayPointPos1 = new Vector3(wayPoint1.transform.position.x, wayPoint1.transform.position.y, wayPoint1.transform.position.z);
		wayPointPos2 = new Vector3(wayPoint2.transform.position.x, wayPoint2.transform.position.y, wayPoint2.transform.position.z);
		wayPointPos3 = new Vector3(wayPoint3.transform.position.x, wayPoint3.transform.position.y, wayPoint3.transform.position.z);




		timer -= Time.deltaTime;

		if(transform.position == wayPointPos3){
			moveTo1 = true;
			moveTo2 = false;
			moveTo3 = false;
		}
		if(moveTo1 == true){
			transform.position = Vector3.MoveTowards(transform.position, wayPointPos1, speed * Time.deltaTime);
		}





		if(transform.position == wayPointPos1)
		{
			moveTo1 = false;
			moveTo2 = true;
			moveTo3 = false;
		}
		if(moveTo2 == true){
			transform.position = Vector3.MoveTowards(transform.position, wayPointPos2, speed * Time.deltaTime);
		}





		if(transform.position == wayPointPos2)
		{
			moveTo1 = false;
			moveTo2 = false;
			moveTo3 = true;
		}
		if(moveTo3 == true){
			transform.position = Vector3.MoveTowards(transform.position, wayPointPos3, speed * Time.deltaTime);
		}





		if(timer <= 0){
			timer = 10;
		}





		if (bossHealth <= 0){
			gameObject.SetActive (false);
		}

	



		if (Time.time >= nextFire) {

			GameObject instance = Instantiate (eyeBullet, transform.position - bulletPos, transform.rotation);
			nextFire = Time.time + 2;
		}





		if (bossHealth == 10){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(true);

		}

		if (bossHealth == 9){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(true);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 8){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(true);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 7){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(true);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 6){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(true);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 5){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(true);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 4){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(true);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 3){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(true);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 2){

			healthBar0.SetActive(false);
			healthBar1.SetActive(false);
			healthBar2.SetActive(true);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 1){

			healthBar0.SetActive(false);
			healthBar1.SetActive(true);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}

		if (bossHealth == 0){

			healthBar0.SetActive(true);
			healthBar1.SetActive(false);
			healthBar2.SetActive(false);
			healthBar3.SetActive(false);
			healthBar4.SetActive(false);
			healthBar5.SetActive(false);
			healthBar6.SetActive(false);
			healthBar7.SetActive(false);
			healthBar8.SetActive(false);
			healthBar9.SetActive(false);
			healthBar10.SetActive(false);

		}


    }




	void OnCollisionEnter2D (Collision2D other){

		if (other.gameObject.tag == "bullet") {

			spikes.SetActive(false);
			spikes2.SetActive(false);
			spikes3.SetActive(false);

			bossHealth -= 1;

	}

}
}