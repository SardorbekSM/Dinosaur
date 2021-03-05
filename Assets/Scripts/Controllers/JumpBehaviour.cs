using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    private float _jumpForce = 7;

    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private LayerMask _whatIsGround;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private float _checkRadius;

    [SerializeField]
    private int _extraJumps = 1;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (CanJump())
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
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
                return true;
            }
        }

        return false;
    }
}
