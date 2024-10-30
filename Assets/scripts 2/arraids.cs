using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraids : MonoBehaviour //Declarar un Array de int y buscar dentro de ese array el valor 5,
 //en caso de encontrarlo imprimir un log: "Encontre el N°5"
//Caso contrario "El N° 5 no se encuentra en el array"
{
   int[] numbers = new int[3];
    void Start()
    {
        numbers[0] = 4;
        numbers[1] = 6;
        numbers[2] = 7;
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == 5)
            {
                Debug.Log($"Encontre el numero 5");
                return;
            }
        }
        Debug.Log($"No encontre el numero 5");

    }

   
    void Update()
    {
        
    }
}
