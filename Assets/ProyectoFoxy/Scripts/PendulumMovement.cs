using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMovement : MonoBehaviour
{
    private Vector2 _startPosition;
    [SerializeField] private Transform _pendulum;

    private void Start()
    {
        _startPosition = _pendulum.localPosition;    
    }

    public void MoveOffset(float offset)
    {
        _pendulum.localPosition = new Vector2(_startPosition.x + offset, _startPosition.x);
    }
}
