using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private int _damage = 1; // Da�o que hace la trampa/pincho
    [SerializeField] private AudioClip trapSound; // Sonido al colisionar con la trampa
    private bool _isPlayerInTrap = false; // Para controlar si el jugador est� dentro de la trampa
    private Coroutine _damageCoroutine; // Referencia a la corutina de da�o

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Reproducir el sonido de la trampa
            AudioSource.PlayClipAtPoint(trapSound, transform.position);

            // Verifica si el jugador ya est� tocando la trampa o pincho
            if (!_isPlayerInTrap)
            {
                _isPlayerInTrap = true;
                if (_damageCoroutine != null)
                {
                    StopCoroutine(_damageCoroutine); // Se detiene cualquier corutina anterior
                }
                _damageCoroutine = StartCoroutine(ApplyDamageRepeatedly(other)); // Inicia la corutina de da�o
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Cuando el jugador sale de la trampa, detiene la corutina
            if (_damageCoroutine != null)
            {
                StopCoroutine(_damageCoroutine);
            }
            _isPlayerInTrap = false;
        }
    }

    private IEnumerator ApplyDamageRepeatedly(Collider2D player)
    {
        Health playerHealth = player.GetComponent<Health>(); 

        // Aplica da�o inicial
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(_damage);
        }

        // Espera 1,5 segundos antes de aplicar el siguiente da�o
        yield return new WaitForSeconds(1.5f);

        // Si el jugador sigue en la trampa o pincho, aplica da�o nuevamente
        while (_isPlayerInTrap)
        {
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(_damage);
            }
            yield return new WaitForSeconds(1.5f); 
        }
    }
}