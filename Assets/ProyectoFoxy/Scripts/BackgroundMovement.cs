using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _speedMovement;
    private Vector2 _offset;
    private Material _material;
    private Rigidbody2D _PlayerRb;


    private void Awake()
    {
        _material = GetComponent<SpriteRenderer>().material;
        _PlayerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _offset = (_PlayerRb.velocity.x * 0.1f) * _speedMovement * Time.deltaTime;
        _material.mainTextureOffset += _offset;  
    }
}

