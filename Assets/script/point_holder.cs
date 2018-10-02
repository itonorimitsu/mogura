using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class point_holder : MonoBehaviour {

	public int points;
	public Text scoretext;

	// Use this for initialization
	void Start () {
		points = 0;
		scoretext.text = "";
	}

	public void attack_success(){
		points += 5;
		scoretext.text = points.ToString();
		Debug.Log ("success");
	}

	public void attack_miss(){
		points -= 10;
		scoretext.text = points.ToString ();
		Debug.Log ("attack_false");
	}

	public void miss_target(){
		points += 5;
		scoretext.text = points.ToString ();
		Debug.Log ("miss");
	}

	public int get_point(){ //結果表示のためにポイントを返す
		return points;
	}
}