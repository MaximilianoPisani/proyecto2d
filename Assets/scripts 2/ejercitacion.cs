using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class ejercitacion : MonoBehaviour
{
    // Crea un sistema de energía para un personaje.
    // El personaje puede ganar o perder energía según la tecla que presione.Usa W para ganar 5 puntos de energía y S para perder 5 puntos.
    // La energía no puede superar los 100 puntos ni caer por debajo de 0. Además, si la energía es menor a 20, el personaje recibe una advertencia visual.
    public int energy =100 ;
    void Start()
    {
       
    }

    void valueEnergy (int energy)
    {
        if ((energy) < 20 )
        {
            Debug.LogWarning("Energia baja");
           

        }

    }
    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            if ((energy + 5) < 101)
            {
                Debug.Log("+ 5 puntos ");
                energy = energy + 5;
                Debug.Log(energy);


            }
            else 
            {
                Debug.Log("Energia no puede superar 100");
                Debug.Log(energy);

            }
            valueEnergy(energy);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if((energy - 5) > -1)
            {
                Debug.Log("- 5 puntos ");
                energy = energy - 5;
                Debug.Log(energy);

            }
            else
            {
                Debug.Log("Energia no puede estar debajo de 0");
                Debug.Log(energy);

            }
            valueEnergy(energy);
        }

    }
}
