using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioClip pickupSound; // Arrastra aquí el sonido desde el Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Reproduce el sonido al recoger el objeto
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            if (CompareTag("IsFinalPickUp"))
            {
                Debug.Log("Last PickUp collected, ending the game.");

                GameManager.Instance.EndGame();
            }

            gameObject.SetActive(false);
        }
    }
}