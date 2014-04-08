using UnityEngine;
using System.Collections;

public class GenerateMobs : MonoBehaviour {
	private Vector2 vec2;
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	private Transform t;
	void Start(){
		t=transform;
		for(int j=1;j<=5;j+=2){
			for(int i=1 ; i<9 ; i++){
				if(Random.value<0.5f){
					vec2.x=i;
					vec2.y=j;

					switch(j){
						case 1:{
							(Instantiate(p1, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							vec2.x=-1*vec2.x;
							(Instantiate(p1, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							break;
						}case 3:{
							(Instantiate(p2, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							vec2.x=-1*vec2.x;
							(Instantiate(p2, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							break;
						}case 5:{
							(Instantiate(p3, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							vec2.x=-1*vec2.x;
							(Instantiate(p3, vec2, Quaternion.identity) as GameObject).transform.parent=t;
							break;
						}
					}

				}
			}
		}
		GetComponent<EnemyMovement>().enabled=true;
	}
	void LateUpdate(){
		if(t.childCount==0)
			Application.LoadLevel(Application.loadedLevel);
	}
}
