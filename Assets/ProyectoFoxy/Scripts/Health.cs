using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    private int _currentHealth;
    public StartPosition startPosition;
    private Animator _animator; 

    // Duraci�n de la animaci�n de "Hit"
    private float _hitAnimationDuration = 0.5f; // Ajusta esto seg�n la duraci�n de tu animaci�n "Hit"

    private bool _isHit = false; // Flag para saber si el personaje est� en "Hit"

    void Start()
    {
        _currentHealth = maxHealth;
        _animator = GetComponent<Animator>(); // Animator del jugador
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Debug.LogError("Damage taken must be greater than 0.");
            return;
        }

        // Si ya est� en "Hit", no hacer nada m�s
        if (_isHit) return;

        _currentHealth -= damage;

        // Animaci�n de "Hit" al recibir da�o
        if (_animator != null)
        {
            _animator.SetTrigger("Hit"); // Activo el Trigger de "Hit"
            _isHit = true; 
        }

        // Se llama a la corutina para esperar el fin de la animaci�n y luego resetear la posici�n
        StartCoroutine(WaitAndResetPosition());

        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    // Corutina para esperar que termine la animaci�n de "Hit" y luego resetear al jugador
    private IEnumerator WaitAndResetPosition()
    {
        // Espera a que termine la animaci�n de "Hit"
        yield return new WaitForSeconds(_hitAnimationDuration);

        // Resetea la posici�n del jugador
        if (startPosition != null)
        {
            startPosition.ResetPlayerPosition();
        }

        // Reproducir la animaci�n de "Idle" despu�s de volver a la posici�n
        if (_animator != null)
        {
            _animator.SetTrigger("Idle"); 
        }

        // Despu�s de respawnear, se libera el flag de "Hit"
        _isHit = false;

        
        Revive();
    }

    public void Die()
    {
        Debug.Log("Foxy is Dead");
     
        Revive(); // Restaura la salud despu�s de mover al jugador
    }

    private void Revive()
    {
        _currentHealth = maxHealth;
        Debug.Log("Foxy revived");
    }

    public float HealthBar()
    {
        return _currentHealth / (float)maxHealth;
    }
}