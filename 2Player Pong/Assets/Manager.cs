using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public float min;
	public float max;

	// Use this for initialization
	void Start () {
		player1.GetComponent<PlayerMove>().setMinMax(min, max);
		player2.GetComponent<PlayerMove>().setMinMax(min, max);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
