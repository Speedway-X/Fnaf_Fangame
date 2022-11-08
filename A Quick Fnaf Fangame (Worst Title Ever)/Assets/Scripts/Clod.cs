using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clod : MonoBehaviour
{
    //Variables para usar Velocidad, Vida y el RigidBody
    public Rigidbody rb;
    float Speed;
    float health = 3f;

    //Varaibles para adquirir propiedades del Jugador, la FlashLight y los booleanos
    GameObject Player;
    Transform PosPlayer;
    public bool IsLightOn;
    GameObject SpawnScript;
    SpawnHallwayRobots spawn;

    //Enum para detectar el estado del Robot
    enum States
    {
        Foward,
        Light,
        Kill
    }
    States state = States.Foward;

    //Adquirir el Transform del jugador
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player != null)
        {
            PosPlayer = Player.GetComponent<Transform>();
        }
        SpawnScript = GameObject.FindGameObjectWithTag("Respawn");
        if (SpawnScript != null)
        {
            spawn = SpawnScript.GetComponent<SpawnHallwayRobots>();
        }
    }

    void FixedUpdate()
    {
        Move();
        CheckLight();
        CheckDistance();
        ChangeState();
    }

    //Método para mover con Rigidbody
    void Move()
    {
        rb.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
    }


    //Método para ver si se esta usando el FlashLight contra el robot
    void CheckLight()
    {
        if(IsLightOn == true)
        {
            state = States.Light;
        }
        else
        {
            state = States.Foward;
        }
    }

    //Método para detener Robot cuando esté cerca del jugador
    void CheckDistance()
    {
        float dist = Vector3.Distance(PosPlayer.position, transform.position);
        if (dist <= 4.037)
        {
            state = States.Kill;
        }
    }

    //Método para cambiar el estado del Robot
    void ChangeState()
    {
        switch (state)
        {
            case States.Foward:
                Speed = 0.5f;
                break;
            case States.Light:
                Speed = 0f;
                health -= Time.deltaTime;
                if(health <= 0f)
                {
                    spawn.Instant = true;
                    Destroy(gameObject);
                }
                break;
            case States.Kill:
                Speed = 0f;
                break;
        }
    }
}
