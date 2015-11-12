using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {

	public GameObject bullet;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			var createdBullet = Instantiate (bullet);
			createdBullet.transform.position = this.transform.position;
			createdBullet.transform.rotation = this.transform.rotation;
		}

	}
}
