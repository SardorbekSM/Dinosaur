using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    private float _jumpForce = 5;

    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private LayerMask _whatIsGround;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private float _checkRadius;

    private int _extraJumps = 1;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }

    private void Update()
    {
        CanJump();        
    }

    private void Jump()
    {
        _rigidbody2D.velocity = Vector2.up * _jumpForce;
    }    

    private void CanJump()
    {
        if (Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _whatIsGround))
        {
            Debug.Log("Is workin");
            _extraJumps = 1;

            if (Input.GetKeyDown(KeyCode.Space) && _extraJumps > 0)
            {
                Jump();
                _extraJumps--;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && _extraJumps == 0)
            {
                Jump();
            }
        }

               
    }
}
