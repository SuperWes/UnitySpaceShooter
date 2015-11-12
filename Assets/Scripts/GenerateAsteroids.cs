using UnityEngine;
using System.Collections;

public class GenerateAsteroids : MonoBehaviour {

	public int asteroidCount = 100;
	public GameObject asteroidPrefab;
	public float minimumSize = 5;
	public float maximumSize = 8;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < asteroidCount; i++) {

			var size = Random.Range(minimumSize, maximumSize);
			var randomScale = new Vector3(size, size, size);
			var x = Random.Range(-100, 100);
			var y = Random.Range(-100, 100);
			var z = Random.Range(-100, 100);
			var randomLocation = new Vector3(x,y,z);

			var asteroid = (GameObject)Instantiate(asteroidPrefab.gameObject, randomLocation, Quaternion.identity);
			asteroid.transform.localScale = randomScale;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
