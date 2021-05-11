using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeController : MonoBehaviour {

	public static int minTimer;
	public static int secTimer;
	public static float msTimer;
	public static string msDisplay;

	public GameObject minBox;
	public GameObject secBox;
	public GameObject msBox;

	void Update () {
		if(FinalLap.isDone == false){
			msTimer += Time.deltaTime * 10;
			msDisplay = msTimer.ToString ("F0");
			msBox.GetComponent<Text> ().text = "" + msDisplay;

			if (msTimer >= 10) {
				msTimer = 0;
				secTimer += 1;
			}

			if (secTimer <= 9) {
				secBox.GetComponent<Text> ().text = "0" + secTimer + ".";
			} else {
				secBox.GetComponent<Text> ().text = "" + secTimer + ".";
			}

			if (secTimer >= 60) {
				secTimer = 0;
				minTimer += 1;
			}

			if (minTimer <= 9) {
				minBox.GetComponent<Text> ().text = "0" + minTimer + ":";
			} else {
				minBox.GetComponent<Text> ().text = "" + minTimer + ":";
			}	
	} else{
			minBox.GetComponent<Text> ().text = "0" + 0 + ":";
			secBox.GetComponent<Text> ().text = "0" + 0 + ".";
			msBox.GetComponent<Text> ().text = "" + "0";

		}
	}
}