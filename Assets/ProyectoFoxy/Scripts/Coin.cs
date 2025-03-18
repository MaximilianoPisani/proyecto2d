using System.Collections;
using System.Collections.Generic;
using Assets.ProyectoFoxy.Scripts.Data;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinData _coinData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
           
            AudioSource.PlayClipAtPoint(_coinData.PickSound, transform.position);

            Destroy(gameObject);
        }
    }
}