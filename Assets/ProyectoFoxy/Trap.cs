using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour

{
    [SerializeField] private Transform _wayPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = _wayPoint.position;
        }
        
    }
}
