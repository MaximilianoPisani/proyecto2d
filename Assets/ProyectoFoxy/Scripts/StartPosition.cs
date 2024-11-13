using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private void Start()
    {
        // Verifico si el Transform del jugador est� asignado
        if (_playerTransform == null)
        {
            Debug.LogError("El Transform del jugador no est� asignado en StartPosition.");
            return;
        }

        // Reseteo la posici�n del jugador al iniciar
        ResetPlayerPosition();
    }

    public void ResetPlayerPosition()
    {
        // reseteo la posici�n si el Transform del jugador est� asignado
        if (_playerTransform != null)
        {
            _playerTransform.position = transform.position;
        }
        else
        {
            Debug.LogError("No se puede resetear la posici�n del jugador porque _playerTransform es null.");
        }
    }

  
    public void SetPlayerTransform(Transform playerTransform)
    {
        _playerTransform = playerTransform;
    }
}
