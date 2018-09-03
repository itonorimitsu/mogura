using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playgame : MonoBehaviour {

	GameObject matchobj;

	void Start () {
		matchobj = GameObject.Find ("match");
		match m = matchobj.GetComponent<match>();
		m.main();
	}
}
