using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miss_shot : MonoBehaviour {

	GameObject score;

	public void Onclicked(){
		Debug.Log ("ミス");
		score = GameObject.Find ("player1_point");
		point_holder p1 = score.GetComponent<point_holder> ();
		p1.attack_miss ();
	}
}
