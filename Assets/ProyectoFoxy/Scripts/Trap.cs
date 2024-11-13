using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifico si el objeto que entra en la trampa es el jugador.
        if (other.CompareTag("Player"))
        {
            // Intentamos obtener el componente Health del jugador.
            var playerHealth = other.GetComponent<Health>();

            // jugador tiene componente Health, le aplicamos daño.
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1); // Aplica daño al jugador
            }
        }
    }
}