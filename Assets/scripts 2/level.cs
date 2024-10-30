using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    //Crea un sistema de experiencia donde el jugador gane puntos de experiencia al derrotar enemigos usando la tecla K. Al ganar 50 puntos de experiencia, el jugador sube de nivel.
    // Cada vez que sube de nivel, la experiencia se reinicia y el nivel incrementa.
    // Usa un bucle for para sumar la experiencia acumulada de hasta 5 enemigos. Muestra el nivel del jugador y su experiencia actual en la consola.
    public int exp = 0;
    int _lvl = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))

        {
            for (int i = 1; i <= 5; i++)
            {
             
            

            exp = exp + 10;
            Debug.Log($"La experiencia es: {exp} ");
            if (exp == 50)
            {
                _lvl = _lvl + 1;
                Debug.Log($"Subiste de nivel {_lvl}");
                exp = 0;
            }

        }

        }
    }
}
