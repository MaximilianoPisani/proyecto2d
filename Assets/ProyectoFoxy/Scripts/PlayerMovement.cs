using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float crawlSpeed = 2f;
    public float jumpForce = 10f;
    private Rigidbody2D _rb;
    public Animator animator;
    private BoxCollider2D _boxCollider;
    public float longitudRaycast = 0.1f;
    public LayerMask capasuelo;
    private bool _enSuelo; 
    private Vector2 _standingColliderSize = new Vector2(1f, 2f);
    private Vector2 _layingDownColliderSize = new Vector2(1f, 1f);
    private Vector2 _standingColliderOffset = new Vector2(0f, 0.5f);
    private Vector2 _layingDownColliderOffset = new Vector2(0f, 0f);

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
        if (_rb == null)
        {
            Debug.LogError("El Rigidbody2D es null!");
        }
        if (_boxCollider == null)
        {
            Debug.LogError("El BoxCollider2D es null!");
        }
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        float velocidadX = moveInput * speed;

        // Actualizar animaci�n de movimiento
        animator.SetFloat("movement", Mathf.Abs(velocidadX));

        // Voltear el personaje al cambiar de direcci�n
        if (velocidadX != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(velocidadX), 1, 1);
        }

        // Aplicar movimiento seg�n estado de tumbado
        if (!animator.GetBool("IsLayingDown"))
        {
            _rb.velocity = new Vector2(velocidadX, _rb.velocity.y);
        }
        else
        {
            float crawlVelocityX = moveInput * crawlSpeed;
            _rb.velocity = new Vector2(crawlVelocityX, _rb.velocity.y);
            animator.SetBool("IsCrawling", moveInput != 0);
        }

        // Detectar si est� en el suelo usando Raycast
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capasuelo);
        _enSuelo = hit.collider != null;

        // Priorizar la animaci�n de salto
        if (Input.GetKeyDown(KeyCode.Space) && _enSuelo)
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("Jump"); // Activar animaci�n de salto con prioridad
        }

        // Cambiar entre animaci�n de ca�da o estar en el suelo
        animator.SetBool("IsFalling", !_enSuelo && _rb.velocity.y < 0);
        animator.SetBool("ensuelo", _enSuelo);

        // Tumbarse
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetLayingDown(true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            SetLayingDown(false);
        }
    }

    void SetLayingDown(bool isLayingDown)
    {
        animator.SetBool("IsLayingDown", isLayingDown);
        _rb.velocity = Vector2.zero;

        if (isLayingDown)
        {
            AdjustColliderForLayingDown();
        }
        else
        {
            AdjustColliderForStanding();
        }
    }

    void AdjustColliderForLayingDown()
    {
        _boxCollider.size = _layingDownColliderSize;
        _boxCollider.offset = _layingDownColliderOffset;
    }

    void AdjustColliderForStanding()
    {
        _boxCollider.size = _standingColliderSize;
        _boxCollider.offset = _standingColliderOffset;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            animator.SetTrigger("Hit");
        }
    }
}