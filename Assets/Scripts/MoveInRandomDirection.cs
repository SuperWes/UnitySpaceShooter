using UnityEngine;
using System.Collections;

public class MoveInRandomDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var rigidBody = GetComponent<Rigidbody> ();
		var x = Random.value * 2 - 1;
		var y = Random.value * 2 - 1;
		var z = Random.value * 2 - 1;
		var randomDirection = new Vector3(x, y, z) * 2;
		rigidBody.velocity = randomDirection;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
