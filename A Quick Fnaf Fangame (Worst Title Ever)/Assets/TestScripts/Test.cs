using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Crear Variables públicas: Vectores de Movimiento y escala, y velocidad del jugador
    public Vector3 Move = new Vector3 (0.1f, 0.1f, 0.1f);
    public Vector3 Scale = new Vector3 (5, 3, 10);
    public float playerSpeed = 0.05f;

    //Asignar Movimiento y Escala inicial
    void Start()
    {
        transform.position = Move;
        transform.localScale = Scale;
    }

    //Asignar Movimiento que cambia con la velocidad del jugador
    void Update()
    {
        transform.position += Move * playerSpeed;
    }
}
