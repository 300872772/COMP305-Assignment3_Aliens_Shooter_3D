using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	// PUBLIC VARIABLES FOR TESTING
	public Transform Target;
	public float Speed;

	// PRIVATE VARIABLES
	private Transform _transform;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		float step = this.Speed * Time.deltaTime;
		this._transform.position = Vector3.MoveTowards(this._transform.position, this.Target.position, step);
	}
}
