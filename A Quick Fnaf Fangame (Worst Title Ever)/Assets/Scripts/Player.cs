using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables para usar las animaciones, la linterna y las cámaras
    public Animator MoveView;
    public GameObject Light;
    public GameObject AtticCam;

    //Enum para detectar posición de la cámara
    enum View
    {
        Center,
        Right,
        Left,
    }
    View view = View.Center;

    //Enum para detectar si la cámara esta abierta
    enum Cams
    {
        Open,
        Close
    }
    Cams cams = Cams.Close;

    //Establecer valores de las variables al principio
    void Start()
    {
        MoveView.SetBool("MoveRight", false);
        MoveView.SetBool("MoveLeft", false);
        Light.SetActive(false);
        AtticCam.SetActive(false);
    }

    void Update()
    {
        RotateView();
        FlashLight();
        UseCam();
        
    }

    //Metodo para rotar vista del jugador
    void RotateView()
    {
        switch (view)
        {
            case View.Center:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    MoveView.SetBool("MoveRight", true);
                    view = View.Right;
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    MoveView.SetBool("MoveLeft", true);
                    view = View.Left;
                }
                break;
            case View.Right:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    MoveView.SetBool("MoveRight", false);
                    view = View.Center;
                }
                break;
            case View.Left:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    MoveView.SetBool("MoveLeft", false);
                    view = View.Center;
                }
                break;
        }
    }

    //Metodo para activar la linterna
    void FlashLight()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Light.SetActive(true);
        }
        else
        {
            Light.SetActive(false);
        }
    }

    //Metodo para usar la cámara
    void UseCam()
    {
        switch (cams)
        {
            case Cams.Close:
                if (Input.GetKeyDown(KeyCode.S))
                {
                    AtticCam.SetActive(true);
                    cams = Cams.Open;
                }
                break;
            case Cams.Open:
                if (Input.GetKeyDown(KeyCode.S))
                {
                    AtticCam.SetActive(false);
                    cams = Cams.Close;
                }
                break;
        }
    }
}
