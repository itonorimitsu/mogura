using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result1 : MonoBehaviour {

	public Text score_text;
	public int point;

	void Start () {
		point = send_point.send1();
		score_text.text = point.ToString();
	}
}
