using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ejercita : MonoBehaviour
{
    // Crea un sistema de salud para un personaje que comience con 100 puntos de vida. El jugador puede recibir daño con la tecla D (pierde 10 puntos de salud POR DEFECTO)
    // y puede regenerar 5 puntos de salud con la tecla R si su vida es menor a 100. El sistema debe asegurar que la salud nunca sea mayor a 100 ni menor a 0.
    // Además, si la salud es menor a 20, el jugador recibirá un mensaje de advertencia.
    // Cuando la salud sea igual a 0 se debe mostrar un estado de Muerto, y solo cuando está muerto, presionando la tecla A el personaje revive.
    public int health = 100; 
    void Start()
    {
        
    }
    void minorHealth(int health)
    {
        if ((health) < 20 && health != 0)
        {
            Debug.LogWarning("El personaje esta herido");
        }
    }
    void die(int health)
    {
        if ((health) == 0) 
        {
            Debug.Log("El personaje esta muerto");
            Debug.Log(health);

        }
    }
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if ((health - 10) > -1)
            {
                Debug.Log("El personaje pierde 10 puntos de salud");
                health = health - 10;
                Debug.Log(health);

            }
            else
            {
                Debug.Log("Salud no puede estar debajo a 0");
                Debug.Log(health);

            }
            minorHealth(health);
            die(health);
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            if ((health + 5) < 101)
            {
                Debug.Log("El personaje regenera 5 puntos de salud");
                health = health + 5;
                Debug.Log(health);
            }
            else 
            {
                Debug.Log("Salud no puede superar 100");
                Debug.Log(health);

            }
            minorHealth(health);
           
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            if ((health == 0))
            {
                health = 100;
                Debug.Log("El personaje revivio");
                Debug.Log(health);
            }


        }



    }
}
