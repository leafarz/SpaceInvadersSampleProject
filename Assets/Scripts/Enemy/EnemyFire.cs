using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {
    private float timer;
    private Vector2 vec2;
	private Transform t;
    public GameObject prefab;


	void Start () {
        timer=Random.value*20;
	}
	
	// Update is called once per frame
	void Update () {
        timer-=Time.deltaTime;
        if(timer<=0){
			vec2=transform.position;
            Instantiate(prefab, vec2, Quaternion.identity) ;
            timer=Random.value*40;
        }
	}
}
