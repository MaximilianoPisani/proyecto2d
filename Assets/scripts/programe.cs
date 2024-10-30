using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class programe : MonoBehaviour
    // escriba un programa que lea un numero del 1 al 7 e imprima el nombre del dia correspondiente de la semana.
{
    int lecture;


    void Start()
    {

     switch (lecture)  
        {    case 1:
                Debug.Log("Hoy es lunes");
                break;
            case 2:

                Debug.Log("Hoy es martes");
                break;
            case 3:

                Debug.Log("Hoy es miercoles");
                break;
            case 4:

                Debug.Log("Hoy es jueves");
                break;
            case 5:

                Debug.Log("Hoy es viernes");
                break;
            case 6:

                Debug.Log("Hoy es sabado");
                break;
            case 7:

                Debug.Log("Hoy es domingo");
                break;
            default:

                Debug.Log("Error");
                break;
        }


    }
    
}
