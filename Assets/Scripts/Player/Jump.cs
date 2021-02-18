using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float _jumpForce = 5;

    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private LayerMask _whatIsGround;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private float _checkRadius;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }

    private void Update()
    {
        if (CanJump())
        {
            _Jump();
        }
    }

    private void _Jump()
    {
        _rigidbody2D.velocity = Vector2.up * _jumpForce;
    }    

    private bool CanJump()
    {
        bool checkGround = Input.GetKeyDown(KeyCode.Space);

        return checkGround;
    }
}
