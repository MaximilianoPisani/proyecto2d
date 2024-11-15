using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    private int _currentHealth;
    public StartPosition startPosition;
    private Animator _animator; 

    // Duración de la animación de "Hit"
    private float _hitAnimationDuration = 0.5f; // Ajusta esto según la duración de tu animación "Hit"

    private bool _isHit = false; // Flag para saber si el personaje está en "Hit"

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

        // Si ya está en "Hit", no hacer nada más
        if (_isHit) return;

        _currentHealth -= damage;

        // Animación de "Hit" al recibir daño
        if (_animator != null)
        {
            _animator.SetTrigger("Hit"); // Activo el Trigger de "Hit"
            _isHit = true; 
        }

        // Se llama a la corutina para esperar el fin de la animación y luego resetear la posición
        StartCoroutine(WaitAndResetPosition());

        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    // Corutina para esperar que termine la animación de "Hit" y luego resetear al jugador
    private IEnumerator WaitAndResetPosition()
    {
        // Espera a que termine la animación de "Hit"
        yield return new WaitForSeconds(_hitAnimationDuration);

        // Resetea la posición del jugador
        if (startPosition != null)
        {
            startPosition.ResetPlayerPosition();
        }

        // Reproducir la animación de "Idle" después de volver a la posición
        if (_animator != null)
        {
            _animator.SetTrigger("Idle"); 
        }

        // Después de respawnear, se libera el flag de "Hit"
        _isHit = false;

        
        Revive();
    }

    public void Die()
    {
        Debug.Log("Foxy is Dead");
     
        Revive(); // Restaura la salud después de mover al jugador
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