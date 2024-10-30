using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    // Cree un programa en C# que calcule la nota de un alumno a partir de un número entero.
    // Solicite al usuario un número (x) y responda lo siguiente:
    // 10- Matrícula de honor, 9- Sobresaliente, 7.8- Notable, 6- Bien, 5- Aprobado, 0.4- Suspenso Use la instrucción switch, break y default de C#.

    public int x;
    void Start()
    { 
        switch (x)
         {
             case 10:
                Debug.Log("Matricula de honor = 10");
                break;
            case 9:
                Debug.Log("Sobresaliente = 9");
                break;
            case 8:
                Debug.Log("Notable = 8");
                break;
            case 7:
                Debug.Log("Notable = 7");
                break;
            case 6:
                Debug.Log("Bien = 6");
                break;
            case 5:
                Debug.Log("Aprobado = 5");
                break;
            case 4:
                Debug.Log("Suspenso = 4");
                break;
            case 3:
                Debug.Log("Suspenso = 3");
                break;
            case 2:
                Debug.Log("Suspenso = 2");
                break;
            case 1:
                Debug.Log("Suspenso = 1");
                break;
            case 0:
                Debug.Log("Suspenso = 0");
                break;
            default:
                Debug.Log("Error");
                break;
            }
        



    }

    
    
     
    
    
    
    
}
      