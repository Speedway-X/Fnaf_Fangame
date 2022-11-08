using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        MoveMega();
        RotateMega();
    }

    //Metodo para mover al personaje
    void MoveMega()
    {
        float MovX = Input.GetAxis("Horizontal");
        float MovY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3 (MovY, 0, MovX) * Speed * Time.deltaTime);
    }

    //Metodo para rotar personaje
    void RotateMega()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -200, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 200, 0) * Time.deltaTime);
        }
    }
}
