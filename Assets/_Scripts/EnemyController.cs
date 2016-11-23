using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public NavMeshAgent Agent;

	// PRIVATE INSTANCE VARIABLES
	private Transform Player;

	// Use this for initialization
	void Start () {
		this.Player = GameObject.FindWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		this.Agent.SetDestination (this.Player.position);
	}
}
