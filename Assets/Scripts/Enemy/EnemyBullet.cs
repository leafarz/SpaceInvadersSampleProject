using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
    private Transform t;
    private Vector2 vec2;
    public float speed=0;
    
    void Start () {
        t=transform;
        vec2=t.position;
    }
    
    void Update () {
        vec2=t.position;
        if(vec2.y>=-3.5){
            vec2.y-=speed*Time.deltaTime;
            t.position=vec2;
        } else Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            col.transform.position=-3.5f*Vector3.up;
			col.GetComponent<Lives>().Hit();
            Destroy(gameObject);
        }
    }
}
