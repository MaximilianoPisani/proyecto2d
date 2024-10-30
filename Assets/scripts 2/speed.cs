using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class speed : MonoBehaviour
{
    //Crea un sistema que controle la velocidad de un personaje. Usa las teclas I para incrementar la velocidad y O para reducirla.
    //La velocidad m�nima es 0 y la m�xima es 20.
    //Si la velocidad est� en su valor m�ximo o m�nimo, no debe cambiar m�s.
    //Adem�s, si la velocidad llega a 0, el sistema debe mostrar un mensaje indicando que el personaje est� detenido.

    int _velocity = 10;
  
    void Start()
    {
        
    }
    bool ValidateVelocity(int velocity) 
    {
        return velocity == 0 || velocity == 20;

    }



    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (ValidateVelocity(_velocity))
            {
                Debug.Log("El personaje no puede cambiar mas");


            }
            else
            {
                Debug.Log("El personaje aumento 10 de velocidad ");
                _velocity = _velocity + 10;
                Debug.Log(_velocity);
            }
           

        }

        if (Input.GetKeyDown(KeyCode.O))
        {

            if (ValidateVelocity(_velocity))
            {
                Debug.Log("El personaje no puede cambiar mas");
                Debug.Log("El personaje esta detenido");

            }
            else
            {
                Debug.Log("El personaje disminuyo 10 de velocidad ");
                _velocity = _velocity - 10;
                Debug.Log(_velocity);
            }
           
        }
    }
}
