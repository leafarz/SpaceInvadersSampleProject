using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {
    private Transform t;
    private Vector2 vec2;
    void Start(){
        t=transform;
    }
	void Update () {
        if(t.position.y<=-3.5){
			vec2=t.position;
            vec2.y=5;
            transform.position=vec2;
        }
	}
}
