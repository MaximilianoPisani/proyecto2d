using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _currentHealth;
    [SerializeField] private Life _life;
    public StartPosition startPosition;
    private Animator _animator;

    private int _hitCount = 0; // Contador de los golpes recibidos

    private float _hitAnimationDuration = 0.5f;
    private bool _isHit = false;
    private bool _isDead = false;

    void Start()
    {
        _currentHealth = _maxHealth;
        _animator = GetComponent<Animator>();
        _life.InitializeLifeBar(_currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;

        
        if (_isDead) return;

        _currentHealth -= damage;
        _hitCount++;
        _life.ChangeCurrentHealt(_currentHealth);


        if (_hitCount == 2)
        {
            // Aquí solo bajamos la vida, pero no activamos animación Hit
            Debug.Log("Foxy ha recibido 2 golpes, pero aún no está muerto.");
        }

        // Si es el tercer golpe y la salud llega a 0
        if (_hitCount >= 3 && _currentHealth <= 0)
        {
            _currentHealth = 0; 

            // Activo la animación de "Hit" en el tercer golpe
            if (_animator != null && !_isDead)
            {
                _animator.SetTrigger("Hit");
            }

            
            StartCoroutine(ReviveAfterHit());
        }
    }

    private IEnumerator ReviveAfterHit()
    {
        // Esperar a que termine la animación de "Hit"
        yield return new WaitForSeconds(_hitAnimationDuration);

        // Revivir al jugador y restablecer la salud
        Revive();
    }

    private void Revive()
    {
        _currentHealth = _maxHealth;
        _life.ChangeCurrentHealt(_currentHealth); // Restablecer la barra de vida

        _isDead = false;
        _isHit = false;
        _hitCount = 0;

        if (_animator != null)
        {
            _animator.ResetTrigger("Hit");
            _animator.SetTrigger("Idle");
        }

        Respawn();

        Debug.Log("Foxy revived");
    }

    public void Respawn()
    {
        // Respawn en el último checkpoint 
        transform.position = CheckpointManager.Instance.GetCheckpoint();
        Debug.Log("Reapareciendo en: " + transform.position);
    }

    public float HealthBar()
    {
        return (float)_currentHealth / _maxHealth;
    }
}