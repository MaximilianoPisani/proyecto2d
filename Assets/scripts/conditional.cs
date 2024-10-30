using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional : MonoBehaviour 
    // Declarar 2 variables numericas e imprimir en consola el nombre y el valor de la variable mayor y menor.
{
    
    void Start()
    {
        int num1 = 6;
        int num2 = 5;
        string cadena = DevolverMayor(num1,num2);
        Debug.Log(cadena);
        
    }

    string DevolverMayor(int num1, int  num2)
    {
        if (num1 > num2)
        {

            return $"num1 es el mayor valor = {num1}";


        }
        else if (num1 < num2)
        {

            return $"num2 es el mayor valor = {num2}";
        }
        else
        {
           return $"num2 es igual a num1: {num1} " + $"= {num2}";
        }
    }
}