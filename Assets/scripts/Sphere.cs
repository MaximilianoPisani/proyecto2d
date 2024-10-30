using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superficie : MonoBehaviour 
    // Calcula la superficie y el volumen de una esfera, dado su radio, surface 4 * PI * radio al cuadrado, volume 4/3 * PI * radio al cubo 
   // radio desde el inspector
{
   

    private float _surface;
    private float _volume;
    
    public float radius = 5;
    void Start()
    {
        _surface = 4 * Mathf.PI * Mathf.Pow(radius, 2);
        _volume = (4 / 3f) * Mathf.PI * Mathf.Pow(radius, 3);
        
        Debug.Log($"Surface = 4 * PI * radius2 = {_surface}");
        Debug.Log($"volume = 4/3 * PI * radius3 = {_volume}");
        

    }

}
    
         
    
        
        

    

