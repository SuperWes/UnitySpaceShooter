using UnityEngine;
using System.Collections;
using System;

public class SelfDestruct : MonoBehaviour {

	DateTime destructTime;
	public int destructTimeMilliseconds;

	// Use this for initialization
	void Start () {
		destructTime = DateTime.Now.AddMilliseconds (destructTimeMilliseconds);
	}
	
	// Update is called once per frame
	void Update () {
		if (DateTime.Now >= destructTime) {
			Destroy (gameObject);
		}
	}
}
