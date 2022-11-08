using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHallwayRobots : MonoBehaviour
{
    public GameObject HallwayRobots;
    public bool Instant = true;
    float RespawnTime = 3f;

    //Enum para elegir el lado para Instanciar
    enum Side
    {
        Center,
        Left,
        Right
    }
    Side side;

    void Update()
    {
        Debug.Log(side);
        if (Instant == true)
        {
            RespawnTime -= Time.deltaTime;
            if(RespawnTime >= 0)
            {
                RespawnTime = 10f;
                InstantToSide();
            }
        }   
    }

    //Hacer que el robot se instancie en un lado aleatorio
    void InstantToSide()
    {
        side = (Side)Random.Range(0, 3);
        switch (side)
        {
            case Side.Center:
                Instantiate(HallwayRobots, new Vector3(-20f, 0.212577f, -3f), Quaternion.Euler(0, 90, 0));
                Instant = false;
                break;
            case Side.Left:
                Instantiate(HallwayRobots, new Vector3(-8f, 0.212577f, -15f), Quaternion.Euler(0, 0, 0));
                Instant = false;
                break;
            case Side.Right:
                Instantiate(HallwayRobots, new Vector3(-8f, 0.212577f, 10f), Quaternion.Euler(0, 180, 0));
                Instant = false;
                break;
        }

    }
}
