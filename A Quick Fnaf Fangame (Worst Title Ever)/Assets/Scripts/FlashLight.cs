using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlashLight : MonoBehaviour
{
    GameObject RobotClod;
    Clod clod;

    //Detectar colisión cuando entre el robot
    void OnTriggerEnter(Collider col)
    {
        RobotClod = GameObject.FindGameObjectWithTag("Clod");
        if (RobotClod != null)
        {
            clod = RobotClod.GetComponent<Clod>();
            if (col.gameObject.CompareTag("Clod"))
            {
                clod.IsLightOn = true;
            }
        } 
    }

    void OnDisable()
    {
        RobotClod = GameObject.FindGameObjectWithTag("Clod");
        if (RobotClod != null)
        {
            clod = RobotClod.GetComponent<Clod>();
            clod.IsLightOn = false;
        }
    }
}
