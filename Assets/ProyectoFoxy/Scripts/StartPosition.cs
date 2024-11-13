using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private void Start()
    {
        // Verifico si el Transform del jugador está asignado
        if (_playerTransform == null)
        {
            Debug.LogError("El Transform del jugador no está asignado en StartPosition.");
            return;
        }

        // Reseteo la posición del jugador al iniciar
        ResetPlayerPosition();
    }

    public void ResetPlayerPosition()
    {
        // reseteo la posición si el Transform del jugador está asignado
        if (_playerTransform != null)
        {
            _playerTransform.position = transform.position;
        }
        else
        {
            Debug.LogError("No se puede resetear la posición del jugador porque _playerTransform es null.");
        }
    }

  
    public void SetPlayerTransform(Transform playerTransform)
    {
        _playerTransform = playerTransform;
    }
}
