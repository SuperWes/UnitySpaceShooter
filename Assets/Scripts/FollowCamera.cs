using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public GameObject target;
	public Vector3 offset = new Vector3 (0, -0.4f, -2f);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null) {
			return;
		}

		Vector3 velocity = Vector3.zero;
		Vector3 forward = target.transform.forward * 2.0f;
		Vector3 needPos = target.transform.position - forward;
		
		transform.position = Vector3.SmoothDamp(transform.position, needPos, ref velocity,0.05f);
//		transform.position = needPos;

		transform.LookAt (target.transform);

		transform.rotation = target.transform.rotation;
	}
}
