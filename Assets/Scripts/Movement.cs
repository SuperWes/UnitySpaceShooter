using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float movementSpeed = 120f;
	public float rotationSpeed = 120f;

	private Rigidbody rigidBody;

	void Start() {
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update () {
		var horizontal = -Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
		var vertical = Input.GetAxisRaw ("Vertical") * Time.deltaTime;
		var horizontal2 = Input.GetAxisRaw ("Horizontal2") * Time.deltaTime;
		var vertical2 = -Input.GetAxisRaw ("Vertical2") * Time.deltaTime;

		transform.Translate (new Vector3 (0f, 0f, vertical * movementSpeed));
//		rigidBody.AddForce (new Vector3 (0f, -vertical * movementSpeed, 0f));

		transform.Rotate (new Vector3 (vertical2 * rotationSpeed, horizontal2 * rotationSpeed, horizontal * rotationSpeed), Space.Self);
	}
}
