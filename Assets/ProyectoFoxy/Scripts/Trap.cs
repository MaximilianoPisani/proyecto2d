using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private AudioClip trapSound; // Sonido al colisionar con la trampa

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifico si el objeto que entra en la trampa es el jugador.
        if (other.CompareTag("Player"))
        {
            // Reproducir el sonido de la trampa
            AudioSource.PlayClipAtPoint(trapSound, transform.position);

            // Intentamos obtener el componente Health del jugador.
            var playerHealth = other.GetComponent<Health>();

            // jugador tiene componente Health, le aplicamos da�o.
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1); // Aplica da�o al jugador
            }
        }
    }
}