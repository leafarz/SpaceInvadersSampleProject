using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public int life=0;
	public GameObject lifeSample;
	public GameObject []tlives;
	private Vector2 initPos;
	void Start(){
		initPos=new Vector2(-12,-4.5f);

		tlives=new GameObject[life];
		for(int i=0;i<life;i++){
			tlives[i]=Instantiate(lifeSample,initPos,Quaternion.identity) as GameObject;
			initPos.x+=1.5f;
		}

	}
	public void Hit(){
		if(life>0) Destroy(tlives[life-1]);
		life--;
		if(life==-1) Application.LoadLevel(Application.loadedLevel);
	}

}
