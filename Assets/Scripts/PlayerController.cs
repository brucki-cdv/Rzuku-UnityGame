using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float _moveInput;
    private Rigidbody2D _rb;
    private bool _facingRight = true;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        _moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_moveInput * speed, _rb.velocity.y);

        if (_facingRight == false && _moveInput > 0)
        {
            Flip();
        } else if(_facingRight == true && _moveInput < 0)
        {
            Flip();
        }
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
           _rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
