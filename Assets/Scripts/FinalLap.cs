using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class FinalLap : MonoBehaviour
{
	public GameObject myCar;
    public GameObject finsihCam;
    public GameObject viewModes;
    public GameObject completeTrig;
    public GameObject otherCar;

    bool raceFinished = false;
    public static bool isDone = false;

    
    void OnTriggerEnter(Collider collision)
    {   
        if (collision.gameObject.tag == "Player") {
        if(raceFinished == false){
            raceFinished = true;
            RaceFinished();
            isDone = true;
        }  
        }
    }

    void RaceFinished()
    {
        myCar.SetActive(false);
        otherCar.SetActive(false);
        completeTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        myCar.GetComponent<CarController>().enabled = false;
        otherCar.GetComponent<CarController>().enabled = false;
        myCar.GetComponent<CarUserControl>().enabled = false;
        otherCar.GetComponent<CarAIControl>().enabled = false;
        myCar.SetActive(true);
        otherCar.SetActive(true);
        myCar.GetComponent<CarAudio>().StopSound();
        myCar.GetComponent<CarAudio>().enabled = false;
        otherCar.GetComponent<CarAudio>().StopSound();
        otherCar.GetComponent<CarAudio>().enabled = false;
        finsihCam.SetActive(true);
        viewModes.SetActive(false);
    }
}
