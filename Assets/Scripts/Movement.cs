using UnityEngine;
using System.Collections;
using System;

public class Movement : MonoBehaviour {

	public float movementSpeed = 120f;
	public float rotationSpeed = 120f;

	private Rigidbody rigidBody;

	void Start() {
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update () {

//		rigidBody.velocity = Vector3.MoveTowards(rigidBody.velocity, Vector3.zero, 0.1f);
//		rigidBody.angularVelocity = Vector3.MoveTowards (rigidBody.angularVelocity, Vector3.zero, 0.75f);

		var horizontal = -Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
		var vertical = Input.GetAxisRaw ("Vertical") * Time.deltaTime;
		var horizontal2 = Input.GetAxisRaw ("Horizontal2") * Time.deltaTime;
		var vertical2 = -Input.GetAxisRaw ("Vertical2") * Time.deltaTime;

		transform.Translate (new Vector3 (0f, 0f, vertical * movementSpeed));
//		rigidBody.AddForce (new Vector3 (0f, -vertical * movementSpeed, 0f));

//		Debug.Log (vertical);
//		rigidBody.AddForce(transform.forward * (vertical * 20.0f));

		transform.Rotate (new Vector3 (vertical2 * rotationSpeed, horizontal2 * rotationSpeed, horizontal * rotationSpeed), Space.Self);
	}
}
