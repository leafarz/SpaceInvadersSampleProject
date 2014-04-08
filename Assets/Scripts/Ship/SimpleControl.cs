using UnityEngine;
using System.Collections;

public class SimpleControl : MonoBehaviour {
	private Transform t;
	private Vector2 vec2;

	void Start(){
		t = transform;
	}
	void Update () {
		vec2 = t.position;
		if (vec2.x < -13) vec2.x = -13;
		else if (vec2.x > 13) vec2.x = 13;

		vec2.x += Input.GetAxis ("Horizontal") * .1f;
		t.position = vec2;
	}
}
