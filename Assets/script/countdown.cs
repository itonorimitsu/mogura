using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour {

	public Text count; //Text用変数
	GameObject croutine;

	public void main() {
		count.text = "";
		StartCoroutine ("count_time");
	}

	private IEnumerator count_time(){
		croutine = GameObject.Find ("match");
		match m = croutine.GetComponent<match> ();
		for (int i = 3; i > 0; i--) {
			count.text = i.ToString ();
			yield return new WaitForSeconds (1.5f);
		}
		count.text = "start";
		m.end_croutine ();
		yield return new WaitForSeconds (0.3f);
		count.text = "";
		yield break;
	}
}
