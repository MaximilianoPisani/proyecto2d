using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private int _damage = 1; // Daño que hace el pincho al personaje
    [SerializeField] private AudioClip spikeSound; // Sonido al colisionar con el pincho

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Compruebo si el objeto con el que el pincho colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Reproducir el sonido del pincho
            AudioSource.PlayClipAtPoint(spikeSound, transform.position);

            // Obtener el componente Health del jugador
            Health playerHealth = other.GetComponent<Health>();

            // Componente Health del jugador, aplicamos el daño
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(_damage); // Llamo al método TakeDamage
                Debug.Log("¡Foxy tocó un pincho y perdió vida!");
            }
        }
    }
}

