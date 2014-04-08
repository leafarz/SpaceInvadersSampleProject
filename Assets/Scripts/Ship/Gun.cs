using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public BulletsHolder bh;
	public int maxBullets=0;
    private Transform t;
    private Bullet []bullets;
	private bool GotBullets=false;
	void Awake(){
		bh.SetNumOfBullets(maxBullets);
	}
    void Start(){
        t=transform;
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Vector3 vec3=t.position;
            vec3.y+=0.5f;
			Bullet b=GetBullet();
			if(b!=null) b.Fire(t.position);
        }
	}

	private Bullet GetBullet(){
		if(!GotBullets){
			bullets=bh.GetBullets();
			GotBullets=true;
		}
		foreach(Bullet b in bullets){
			if(!b.enabled) return b;
		}
		return null;
	}
}
