using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //private float _speed;
    private float _jumpForce = 5;
    //private float _moveInput;

    private bool _isGrounded;

    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private LayerMask whatIsGround;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private float checkRadius;

    private int _extraJumps = 1;


    private void Start()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }

    private void Update()
    {
        
        if (_isGrounded == true)
        {
            _extraJumps = 1;
        }

        if(Input.GetKeyDown(KeyCode.Space) && _extraJumps > 0)
        {
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
            _extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && _extraJumps > 0)
        {
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
        }
    }
}
