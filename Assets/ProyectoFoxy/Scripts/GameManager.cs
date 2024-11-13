using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    private int totalCoins = 0; // Contador de monedas

    private void Awake()
    {
        // Asegura de que solo exista una instancia de GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantiene el GameManager entre escenas
        }
        else
        {
            Destroy(gameObject); // Si ya existe una instancia, destruye este objeto
        }
    }

    // Método para agregar monedas al contador
    public void AddCoins(int amount)
    {
        totalCoins += amount;
        Debug.Log("Monedas totales: " + totalCoins);
    }
}