using UnityEngine;
using System.Collections;

public class ExplodeThingsThatAreHit : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (explosion != null) {
			Instantiate (explosion, other.transform.position, Quaternion.identity);
		}
		var objectToDuplicate = other.GetComponent<DuplicateOnExplode> ();
		if (objectToDuplicate) {
			objectToDuplicate.SpawnChildren (2);
		}
		Destroy(other.gameObject);
		Destroy (gameObject);
	}

}
