using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mogura_controll : MonoBehaviour {

	GameObject moguraobj1;
	GameObject moguraobj2;
	GameObject moguraobj3;
	GameObject moguraobj4;
	GameObject moguraobj5;
	GameObject moguraobj6;
	GameObject moguraobj7;

	//7つのモグラの参照?
	//絶対もっと綺麗にできる
	public void all () {
		moguraobj1 = GameObject.Find ("mogura1");
		updown m1 = moguraobj1.GetComponent<updown>();
		m1.up ();

		moguraobj2 = GameObject.Find ("mogura2");
		updown m2 = moguraobj2.GetComponent<updown>();
		m2.up ();

		moguraobj3 = GameObject.Find ("mogura3");
		updown m3 = moguraobj3.GetComponent<updown>();
		m3.up ();

		moguraobj4 = GameObject.Find ("mogura4");
		updown m4 = moguraobj4.GetComponent<updown>();
		m4.up ();

		moguraobj5 = GameObject.Find ("mogura5");
		updown m5 = moguraobj5.GetComponent<updown>();
		m5.up ();

		moguraobj6 = GameObject.Find ("mogura6");
		updown m6 = moguraobj6.GetComponent<updown>();
		m6.up ();

		moguraobj7 = GameObject.Find ("mogura7");
		updown m7 = moguraobj7.GetComponent<updown>();
		m7.up ();
	}
	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.Keypad1)) {
//			Debug.Log ("1");
//		}else if (Input.GetKeyDown (KeyCode.Keypad2)) {
//			Debug.Log ("2");
//		}else if (Input.GetKeyDown (KeyCode.Keypad3)) {
//			Debug.Log ("3");
//		}else if (Input.GetKeyDown (KeyCode.Keypad4)) {
//			Debug.Log ("4");
//		}else{
//			Debug.Log ("the other");
//		}
//	}

	/*
	**クリックの状態を入手して多重入力を防ぐ(これ重要!!!!)
	**/
	public void num_receive(int num){
		if (num == 1) {
			moguraobj1 = GameObject.Find ("mogura1");
			updown m1 = moguraobj1.GetComponent<updown> ();
			m1.up ();
//			Debug.Log ("戻ってきた");
		} else if (num == 2) {
			moguraobj2 = GameObject.Find ("mogura2");
			updown m2 = moguraobj2.GetComponent<updown> ();
			m2.up ();
		} else if (num == 3) {
			moguraobj3 = GameObject.Find ("mogura3");
			updown m3 = moguraobj3.GetComponent<updown> ();
			m3.up ();
		} else if (num == 4) {
			moguraobj4 = GameObject.Find ("mogura4");
			updown m4 = moguraobj4.GetComponent<updown> ();
			m4.up ();
		} else if (num == 5) {
			moguraobj5 = GameObject.Find ("mogura5");
			updown m5 = moguraobj5.GetComponent<updown> ();
			m5.up ();
		} else if (num == 6) {
			moguraobj6 = GameObject.Find ("mogura6");
			updown m6 = moguraobj6.GetComponent<updown> ();
			m6.up ();
		} else if (num == 7) {
			moguraobj7 = GameObject.Find ("mogura7");
			updown m7 = moguraobj7.GetComponent<updown> ();
			m7.up ();
		} else {
			//none
		}
	}
}
