using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class send_point : MonoBehaviour {

	public static int point1;
	public static int point2;

	GameObject Score_p1;
	GameObject Score_p2;

//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	public void init(){
		Score_p1 = GameObject.Find ("player1_point");
		point_holder p1 = Score_p1.GetComponent<point_holder>();
		point1 = p1.get_point ();

		Score_p2 = GameObject.Find ("player2_point");
		point_holder p2 = Score_p2.GetComponent<point_holder>();
		point2 = p2.get_point ();
	}

	public static int send1(){
		return point1;
	}

	public static int send2(){
		return point2;
	}

	void Awake () {
		Debug.Log ("awake");
		DontDestroyOnLoad(this);
	}
}
