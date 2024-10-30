using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; 
    public float jumpForce = 10f;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        if (_rb == null) 
        {
            Debug.LogError("El rigidbody es null!!!!!");
        }
    }    


    void Update()
    {

        { 
            // Movimiento horizontal
            float moveInput = Input.GetAxis("Horizontal");
            _rb.velocity = new Vector2 (moveInput * speed, _rb.velocity.y);
        }
        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
        }

        if (Input.GetKeyDown(KeyCode.S))
        { 
          Debug.Log("Foxy lay down ");
        }
     
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Foxy is moving an object ");
        }
       
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Foxy is running ");
        }
    }
}
