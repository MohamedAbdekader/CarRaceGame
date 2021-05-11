using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class posDown : MonoBehaviour
{
    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
    }

}
