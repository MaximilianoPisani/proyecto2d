using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private void Start()
    {
        if (_playerTransform == null)
        {
            Debug.LogError("El Transform del jugador no está asignado en StartPosition.");
            return;
        }

        // Coloca al jugador en el último checkpoint guardado
        _playerTransform.position = CheckpointManager.Instance.GetCheckpoint();
    }

    public void ResetPlayerPosition()
    {
        _playerTransform.position = CheckpointManager.Instance.GetCheckpoint();
    }

    public void SetPlayerTransform(Transform playerTransform)
    {
        _playerTransform = playerTransform;
    }
}