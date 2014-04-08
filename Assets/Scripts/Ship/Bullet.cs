using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    private Transform t;
    private Vector2 vec2;
	private Vector2 initPos;
    public float speed=0;

	void Start () {
        t=transform;
        vec2=t.position;
		initPos=t.position;
		enabled=false;
	}
	
	void Update () {
        vec2=t.position;
        if(vec2.y<=10){
			vec2.y+=speed*Time.deltaTime;
			t.position=vec2;
		} else enabled=false;
	}

	public void Fire(Vector2 pos){
		t.position=pos;
		enabled=true;
	}

    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Enemy")){
            Destroy(col.gameObject);
			t.position=initPos;
			enabled=false;
        }
    }
}
