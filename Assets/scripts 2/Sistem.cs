using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    // Crea un sistema de recolección de recursos donde el jugador pueda cosechar Madera y Piedra usando las teclas W y P respectivamente.
    // El jugador puede almacenar hasta 20 unidades de cada recurso. Cada vez que el jugador recoge un recurso, se agrega a una lista.
    // Si el jugador presiona T, se muestra la cantidad total de cada recurso recolectado.
    public int wood;
    public int stone;
    List<string> resource = new List<string>();
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 

         if ((wood + 5) < 21) 
        {
                Debug.Log("Se recolecto 5 de madera");
                resource.Add($"Se recolecto 5 de madera");
                wood = wood + 5;
                Debug.Log(wood);
        }
        if (Input.GetKeyDown(KeyCode.P))

            if ((stone + 5) < 21)
            {
                Debug.Log("Se recolecto 5 de piedra");
                resource.Add($"Se recolecto 5 de piedra");
                stone = stone + 5;
                Debug.Log(stone);
            }
        if (Input.GetKeyDown(KeyCode.T))
        {

            
            for(int i = 0; i < resource.Count; i++)
            {
                Debug.Log("Number in position " + i + ": " + resource[i]);
            }
        }
    }
}
