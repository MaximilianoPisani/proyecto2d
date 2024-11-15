using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (CompareTag("IsFinalPickUp"))
            {
                Debug.Log("Last PickUp collected, ending the game.");
               
                GameManager.Instance.EndGame();
            }

           
            gameObject.SetActive(false);
        }
    }
}