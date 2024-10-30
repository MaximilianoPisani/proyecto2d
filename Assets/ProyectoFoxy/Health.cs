using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    private int _currentHealth;
    
    void Start()
    {
        
        _currentHealth = maxHealth;
    }

    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
      _currentHealth = _currentHealth - damage;
         {
            if (damage < 0) 
            {

                Debug.LogError("Damage taken is less than 0 ");
                return;             
            }

            if (_currentHealth <= 0)
            {
                Die();
            }

         }
    }
    private void Revive() 
    {
        _currentHealth = maxHealth;
        Debug.Log("Foxy revived ");
    }
    private void Die()
    {
        Debug.Log("Foxy is Dead ");
        Revive();

    }
    public float HealthBar() 
    {
        return _currentHealth / (float) maxHealth;
    }


}
