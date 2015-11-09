using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.gameObject.CompareTag ("Ball")) {
			player.GetComponent<PlayerMo
		}
	}
}
