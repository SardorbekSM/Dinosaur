using UnityEngine;

public class Jumping : MonoBehaviour
{
    private float _jumpForce = 7;

    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private LayerMask _whatIsGround;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private float _checkRadius;

    private int _extraJumps = 1;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }

    private void Update()
    {
        if(CanJump())
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody2D.velocity = Vector2.up * _jumpForce;
    }    

    private bool CanJump()
    {
        if (Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _whatIsGround))
        {
            _extraJumps = 1;

            if (Input.GetKeyDown(KeyCode.Space) && _extraJumps > 0)
            {
                _extraJumps--;
                return true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && _extraJumps == 0)
            {
                Jump();
                return true;
            }
        }

        return false;
    }
}
