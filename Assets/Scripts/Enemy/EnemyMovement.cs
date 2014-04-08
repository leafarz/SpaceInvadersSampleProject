using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    private Vector2 vec2;
    private Transform[] tArray;
    private float timer=3;
    private bool left=false;
    private int horCounter=10;
	
	// Update is called once per frame
	void FixedUpdate () {
        timer-=Time.deltaTime;
        if(timer<0){
            tArray=transform.GetComponentsInChildren<Transform>();
            if(horCounter==19){
                left=!left;
                foreach(Transform t in tArray){
                    vec2=t.position;
                    vec2.y-=0.5f;
                    t.position=vec2;
                }
                horCounter=0;
            }else{
				foreach(Transform t in tArray){
	                vec2=t.position;
					if(left) vec2.x+=0.25f;
                    else vec2.x-=0.25f;
					t.position=vec2;
				}
                horCounter++;
            }
			timer=3;
		}
	}
    
}
