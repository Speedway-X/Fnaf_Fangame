using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Crear variable del posición del jugador
    public Transform posPlayer;

    void Update()
    {
        LookPlayer();
    }

    //Metodo para mirar al jugador
    void LookPlayer()
    {
        transform.LookAt(posPlayer);
    }
    
}
