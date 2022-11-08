using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //Crear variable del posición del jugador
    public Transform posPlayer;
    float Speed;

    void Update()
    {
        LookPlayer();
        FollowPlayer();
        MoveEnemy();
    }

    //Metodo para mirar al jugador
    void LookPlayer()
    {
        transform.LookAt(posPlayer);
    }

    //Metodo para mover y detener al enemigo
    void MoveEnemy()
    {
        float dist = Vector3.Distance(posPlayer.position, transform.position);
        if (dist < 2)
        {
            Speed = 0;
        }
        else
        {
            Speed = 2f;
        }

    }

    //Metodo para seguir al jugador
    void FollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, posPlayer.position, Speed * Time.deltaTime);
    }
}
