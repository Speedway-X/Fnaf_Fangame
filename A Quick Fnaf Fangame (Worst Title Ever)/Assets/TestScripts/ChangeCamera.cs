using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;

    void Start()
    {
        camOne.SetActive(true);
        camTwo.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCamera();
        }
    }

    //Metodo para cambiar cámara
    void ToggleCamera()
    {
        if (camOne.activeInHierarchy)
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);
        } else
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);
        }
    }
}
