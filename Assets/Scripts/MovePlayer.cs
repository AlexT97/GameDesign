﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float speed;
	public Rigidbody Player;
	public GameObject PlayerObject;

	void Start()
	{
		Player = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		HandleInput ();
	}

	private void HandleInput() {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.forward);
		}
		
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (-Vector3.up);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up);
		}
	}

	void OnCollisionEnter(Collision collision) {
		switch (collision.gameObject.tag) {
		case "Zombie":
			PlayerObject.SetActive(false);
			break;
		default:
			PlayerObject.SetActive(true);
			break;
		}
	}
}



