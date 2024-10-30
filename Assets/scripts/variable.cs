using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variab : MonoBehaviour
    // Imprimir en consola la sucesion de numeros desde el 0 a la variable de menor valor ej: si mi variable menor es 3 en consola
       // deberia imprimir numeros 0, 1, 2, 3.
{
    
    void Start()
    {
        int var;
        var = 3;
        for (int i = 0; i <= var; i++)
        {
            Debug.Log(i); 
        }

    }

    
}
