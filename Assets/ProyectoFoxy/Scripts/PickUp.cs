using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int coinValue = 1; // Valor base de cualquier pickup

    protected virtual void OnPickup(GameObject player)
    {
        // Accedemos a la instancia de GameManager y llamamos a AddCoins
        if (GameManager.instance != null)
        {
            GameManager.instance.AddCoins(coinValue);
            Debug.Log("Pickup recogido! Valor: " + coinValue);
        }
        else
        {
            Debug.LogWarning("No se encontró una instancia de GameManager en la escena.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnPickup(collision.gameObject);
            Destroy(gameObject);
        }
    }
}