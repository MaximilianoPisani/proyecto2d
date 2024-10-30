using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{
    // Escriba un programa en C# que solicite un número (x) y una cantidad (y). Muestre ese número tantas veces como la cantidad(y).
    int x = 2;
    int y = 6;
    void Start()
    {
        for (int i = 1; i <= y; i++)
        {
            Debug.Log(x);
        }
    }

    
    void Update()
    {
        
    }
}
