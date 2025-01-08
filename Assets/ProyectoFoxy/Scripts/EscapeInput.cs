using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeInput : MonoBehaviour
{
    void Update()
    {
        // Detectar si se presiona la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Saliendo del juego...");
            Application.Quit();  // Cierra la aplicación
        }
    }
}