using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			col.transform.position=-3.5f*Vector3.up;
			col.GetComponent<Lives>().Hit();
			Destroy(gameObject);
		}
	}
}
