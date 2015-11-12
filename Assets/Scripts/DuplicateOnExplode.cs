using UnityEngine;
using System.Collections;

public class DuplicateOnExplode : MonoBehaviour {

	public int hitPoints = 5;

	void OnDestroy() {
	}
	
	public void SpawnChildren (int childCount)
	{
		for (int i = 0; i< childCount; i++) {
			if (hitPoints > 0) {
				var child = (GameObject)Instantiate (gameObject, transform.position, transform.rotation);
				var explosionComponent = child.GetComponent<DuplicateOnExplode>();
				child.transform.localScale = transform.localScale * 0.75f;
				explosionComponent.hitPoints = hitPoints - 1;
			}
		}
	}
}
