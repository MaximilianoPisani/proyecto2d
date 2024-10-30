using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour
{
    // Cree un programa en C# que solicite un rango de números al usuario (x,y) y muestre las tablas de multiplicar de x hasta y.

    public int x = 2;
    public int y = 5;

    void Start()

    {
        
        for (int i = 1; i <= y; i++)
        {
            Debug.Log($"{x} * {i} es " + Multiplicar(x, i));
            
        }


    }

    float Multiplicar(int a, int b)
    { 
       return a * b;
    
    }

    void Update()
    {
        
    }
}
