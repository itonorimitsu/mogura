using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class match : MonoBehaviour {

	/*
	 * あくまでゲームマッチなので、開始から終了まで。
	 * 
	 */
	GameObject countobj;
	GameObject sender;
	GameObject mogura;

	public void main() {
		/*
		 * カウントダウンを行なっている
		 */
		enabled = false;
		countobj = GameObject.Find ("countdown");
		countdown c1 = countobj.GetComponent<countdown>();
		c1.main ();
	}
	
	// Update is called once per frame
	void Update () {
		mogura = GameObject.Find ("moles");
		mogura_controll m = mogura.GetComponent<mogura_controll> ();
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			// Debug.Log ("1");
			m.num_receive (1);
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			// Debug.Log ("2");
			m.num_receive (2);
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			// Debug.Log ("3");
			m.num_receive (3);
		} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			// Debug.Log ("4");
			m.num_receive (4);
		} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
			// Debug.Log ("5");
			m.num_receive (5);
		} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
			// Debug.Log ("6");
			m.num_receive (6);
		} else if (Input.GetKeyDown (KeyCode.Alpha7)) {
			// Debug.Log ("7");
			m.num_receive (7);
		} else if (Input.GetKeyDown (KeyCode.E)) {
			Debug.Log ("end game");
			SceneManager.LoadScene ("result");
		} else {
			//none
		}
		/*
		 *時間経過後にシーンの遷移を行う 
		**/
// 		if (Time.timeSinceLevelLoad > 20.0f){
// //			gameobject.GetComponent<match>().();
// 			sender = GameObject.Find ("dont_death");
// 			send_point sp = sender.GetComponent<send_point>();
// 			sp.init ();
// 			SceneManager.LoadScene ("result", LoadSceneMode.Single);
// 		}

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
  		Debug.DrawRay (ray.origin, ray.direction * 100, Color.red, 3, false);
	}

	public void end_croutine(){
		enabled = true;
	}
}


//資材置き場

//		moguraobj1 = GameObject.Find ("mogura1");
//		updown m1 = moguraobj1.GetComponent<updown>();
//		m1.up ();
//		mogura = GameObject.Find("moles");
//		mogura_controll m = mogura.GetComponent<mogura_controll> ();
//		m.all ();
