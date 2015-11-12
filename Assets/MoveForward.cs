using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = 30.0f;
	
	// Update is called once per frame
	void Update () {
//		transform.position = transform.forward * speed;
//		transform.position += transform.rotation;
		transform.position += transform.forward * Time.deltaTime * speed;
	}
}
