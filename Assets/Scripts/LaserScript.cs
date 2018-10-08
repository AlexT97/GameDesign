using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	public ParticleSystem Laser;
	public AudioSource Sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Laser.Play();
			Sound.Play();
		} else {
			Laser.Stop();
			Sound.Stop();
		}
	}
}
