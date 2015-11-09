using UnityEngine;
using System.Collections;

public class Player2Move : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y + speed * Time.deltaTime, -3, 3), 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y - speed * Time.deltaTime, -3, 3), 0);
		}
	}
}



public class Manager : MonoBehaviour { 

	public GameObject player1;


	//...some method

	player