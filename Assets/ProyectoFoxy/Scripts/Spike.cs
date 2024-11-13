using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private int damage = 1; // Da�o que hace el pincho al personaje

 
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Compruebo si el objeto con el que el pincho colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Obtener el componente Health del jugador
            Health playerHealth = other.GetComponent<Health>();

            // Componente Health del jugador,aplicamos el da�o
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage); // Llamo al m�todo TakeDamage
                Debug.Log("�Foxy toc� un pincho y perdi� vida!");
            }
        }
    }
}


