using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Calculator : MonoBehaviour
// calcula el resultado de sumar, restar, multiplicar y dividir dos numeros declarados en variables por el usuario y calcula el resto de la division en la ultima linea.
{

    public float a;
    public float b;

    void Start()
    {
        Debug.Log(SumarDosNumeros (a,b));

        Debug.Log(a / b);// esto es una division
        Debug.Log(a + b);// esto es una suma
        Debug.Log(a * b);// esto es una multiplicacion
        Debug.Log(a - b);// esto es una resta
        Debug.Log(a % b);// esto es el resto
    }
    float SumarDosNumeros(float a, float b)
    {
        return a + b;
    
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            
        }
    }

}
