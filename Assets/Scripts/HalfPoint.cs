using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPoint : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "Player") {
			LapCompleteTrig.SetActive (true);
			HalfLapTrig.SetActive (false);
		}else{		}
	}
}