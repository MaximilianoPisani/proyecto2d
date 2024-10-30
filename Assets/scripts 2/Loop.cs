using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Loop : MonoBehaviour // Cree un programa en C# que solicite al usuario dos números enteros (x, y) y muestre
 // el rango de esos números (los dos incluidos), de tres maneras diferentes:Usando la instrucción for. Usando la instrucción while.
 // Usando la instrucción do while.
{
    int x = 6;
    int y = 2;
    void Start()

    {
        int i = y;
        while (i < x)
        {
            Debug.Log(i);
            i++;
        }
        for (int j = y; j < x; j++)
        {
           Debug.Log(j);
        }
        int l = y;
        do
        {
            Debug.Log(l);
            l++;
        } while (l < x);










    }










    void Update()
    {
        
    }
}
