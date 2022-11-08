using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hybrid : MonoBehaviour
{
    //Crear variable del posición del jugador, velocidad del enemigo y un enum
    public Transform posPlayer;
    float Speed;
    public enum Attack
    {
        Look,
        Follow
    }
    public Attack attack;
    
    void Update()
    {
        ChoseAttack();
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
        if(dist < 2)
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

    //Switch para cambiar de Ataque
    void ChoseAttack()
    {
        switch (attack)
        {
            case Attack.Look:
                LookPlayer();
                break;
            
            case Attack.Follow:
                LookPlayer();
                FollowPlayer();
                MoveEnemy();
                break;
        }
    }
}
