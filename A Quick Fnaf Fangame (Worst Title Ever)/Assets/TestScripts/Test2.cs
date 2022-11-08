using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    //Crear variables Vida, Velocidad y Dirrección.
    int Health = 100;
    float playerSpeed = 5f;
    Vector3 Move = new Vector3 (1f, 1f, 1f);

    void Start()
    {
        Debug.Log(Health);
    }

    //Hacer que los métodos activados cambien por frames y se muestren en consola
    void Update()
    {
        playerMovement();
        Damage();
        Debug.Log(Health);
        gainHeatlh();
        Debug.Log(Health);
    }

    //Método de movimiento
    void playerMovement()
    {
        transform.position += Move * playerSpeed * Time.deltaTime;
    }

    //Método para ganar vida
    void gainHeatlh()
    {
        Health++;
    }

    //Método para perder vida
    void Damage()
    {
        Health--;
    }
}
