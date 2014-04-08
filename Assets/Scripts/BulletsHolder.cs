using UnityEngine;
using System.Collections;

public class BulletsHolder : MonoBehaviour {
	public GameObject bullet;
	private Bullet []bullets;
	private int maxBullets=0;
	private Vector2 vec2;
	private Transform t;
	void Start () {
		t=transform;
		vec2=t.position;
		bullets=new Bullet[maxBullets];
		for(int i=0;i<maxBullets;i++){
			(Instantiate(bullet, vec2, Quaternion.identity) as GameObject).transform.parent=t;
		}
		bullets=GetComponentsInChildren<Bullet>();
	}

	public void SetNumOfBullets(int i){
		maxBullets=i;
	}

	public Bullet[] GetBullets(){
		return bullets;
	}
	
}
