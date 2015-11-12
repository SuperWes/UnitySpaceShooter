using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public Vector3 rotation;

	// Use this for initialization
	void Start () {
		rotation = new Vector3 (1f, 2f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotation, Space.World);
	}
}
