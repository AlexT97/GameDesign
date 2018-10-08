using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.AI;

public class MoveAI : MonoBehaviour
{
    public Transform target;
	public GameObject EnemyObject;
    Vector3 destination;
    NavMeshAgent agent;

    void Start()
    {
		// Random starting locations
		transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(0.1f, 10.0f), Random.Range(-500.0f, 500.0f));		
		
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    void Update()
    {
		if (target.position.magnitude - transform.position.magnitude > 100.0) {
			destination = new Vector3(Random.Range(-500.0f, 500.0f), 0.1f, Random.Range(-500.0f, 500.0f));
			agent.destination = destination;
		} else {
        	destination = target.position;
       		agent.destination = destination;
		}
    }

	void OnCollisionEnter(Collision collision) {
		switch (collision.gameObject.tag) {
		case "Laser":
			EnemyObject.SetActive(false);
			break;
		default:
			EnemyObject.SetActive(true);
			break;
		}
	}
}














/*
public class MoveAI : MonoBehaviour {

	public GameObject player;
	private Vector3 distance;
	private Vector3 moves;
	private float mag;
	public float speed;


	void Start()
	{
		//transform.position = new Vector3(Random.Range(-500.0f, 500.0f), 0.1f, Random.Range(-500.0f, 500.0f));

		// The funny version
		transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(0.1f, 10.0f), Random.Range(-500.0f, 500.0f));
	}

	void FixedUpdate()
	{
		distance = transform.position - player.transform.position;
		mag = distance.magnitude;
		moves = new Vector3 (distance.normalized.x*speed, 0.1f, distance.normalized.z*speed);
		
		transform.position = new Vector3 (transform.position.x - moves.x, 0.1f, transform.position.z - moves.z);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			other.gameObject.SetActive(false);
			//count = count + 1;
			//SetCountText ();
		}
	}

}*/
