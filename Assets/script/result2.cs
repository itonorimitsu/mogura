using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result2 : MonoBehaviour {

	public Text score_text;
	public int point;

	void Start () {
		point = send_point.send2();
		score_text.text = point.ToString();
	}
}
