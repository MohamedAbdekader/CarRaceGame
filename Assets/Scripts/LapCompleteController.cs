using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteController : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	public GameObject minDisplay;
	public GameObject secDisplay;
	public GameObject msDisplay;
	public GameObject lapCounter;
	public int laps;
	public GameObject RaceFinished;

	void Update(){
		if(laps == 1){
			RaceFinished.SetActive(true);
		}
	}
	 

	void OnTriggerEnter(Collider collision) {
	 	if (collision.gameObject.tag == "Player") {
			laps = laps + 1;
			if (LapTimeController.secTimer <= 9) {
				secDisplay.GetComponent<Text> ().text = "0" + LapTimeController.secTimer + ".";
			} else {
				secDisplay.GetComponent<Text> ().text = "" + LapTimeController.secTimer + ".";
			}

			if (LapTimeController.minTimer <= 9) {
				minDisplay.GetComponent<Text> ().text = "0" + LapTimeController.minTimer + ".";
			} else {
				minDisplay.GetComponent<Text> ().text = "" + LapTimeController.minTimer + ".";
			}

			msDisplay.GetComponent<Text> ().text = "" + LapTimeController.msTimer;

			LapTimeController.minTimer = 0;
			LapTimeController.secTimer = 0;
			LapTimeController.msTimer = 0;

			lapCounter.GetComponent<Text> ().text = "" + laps;
			HalfLapTrig.SetActive (true);
			LapCompleteTrig.SetActive (false);
		
		 }else{}
	}
}
