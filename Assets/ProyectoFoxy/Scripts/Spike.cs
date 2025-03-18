using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private int _damage = 1; // Daño que hace el pincho al personaje
    [SerializeField] private AudioClip spikeSound; // Sonido al colisionar con el pincho

    private bool _isPlayerInSpike = false; // Controla si el jugador está tocando el pincho
    private Coroutine _damageCoroutine; // Referencia a la corutina de daño

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Compruebo si el objeto con el que el pincho colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Reproducir el sonido del pincho
            AudioSource.PlayClipAtPoint(spikeSound, transform.position);

            
            if (!_isPlayerInSpike)
            {
                _isPlayerInSpike = true;
                if (_damageCoroutine != null)
                {
                    StopCoroutine(_damageCoroutine); // Se detiene cualquier corutina anterior
                }
                _damageCoroutine = StartCoroutine(ApplyDamageRepeatedly(other)); // Inicia la corutina de daño
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Si el jugador sale del pincho, se detiene la corutina de daño
        if (other.CompareTag("Player"))
        {
            if (_damageCoroutine != null)
            {
                StopCoroutine(_damageCoroutine);
            }
            _isPlayerInSpike = false; // El jugador ya no está en el pincho
        }
    }

    private IEnumerator ApplyDamageRepeatedly(Collider2D player)
    {
        Health playerHealth = player.GetComponent<Health>(); 

        // Aplica daño inicial
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(_damage);
        }

        // Espera 1,5 segundos antes de aplicar el siguiente daño
        yield return new WaitForSeconds(1.5f);

        // Si el jugador sigue en el pincho, aplica daño nuevamente
        while (_isPlayerInSpike)
        {
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(_damage); // Aplica daño
            }
            yield return new WaitForSeconds(1.5f); // Espera 1,5 segundos antes de aplicar el siguiente daño
        }
    }
}