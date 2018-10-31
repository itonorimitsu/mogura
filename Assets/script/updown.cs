using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour {

	GameObject score;

	const int minPoint = -11; // 下限が-12でした
	const int maxPoint = 1; //上限が1でした

	public void up(){
		// if (this.transform.position.y <= 0) {
		// 	Vector3 pos = this.transform.position;
		// 	pos.y += 1;
		// 	this.transform.position = pos;
		GetComponent<CapsuleCollider>().enabled = true;
		StartCoroutine ("UpMethod");
		Invoke ("timeout", 3.0f);
		// }
	}

	public void down(){
		GetComponent<CapsuleCollider>().enabled = false;
		CancelInvoke();
		StartCoroutine ("DownMethod");
	}

	void timeout(){//こっちは座標の処理も必要
		if (this.transform.position.y >= 0) { //0より小さければ下降を初めているので
			StartCoroutine ("DownMethod");
			score = GameObject.Find ("player2_point"); //ここでマテリアルを変更させる
			point_holder p2 = score.GetComponent<point_holder>();
			p2.miss_target ();
		}
	}

	private IEnumerator UpMethod(){
		while(this.transform.position.y < maxPoint){
			this.transform.position += new Vector3 (0, 3, 0);
			yield return null;
			// Debug.Log ("up");
		}
	}

	private IEnumerator DownMethod(){
		while(this.transform.position.y >= minPoint) {
			this.transform.position += new Vector3 (0, -1, 0);
			yield return null;
			// Debug.Log ("down");
		}
	}
}
