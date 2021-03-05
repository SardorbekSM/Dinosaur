using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    protected Vector3 position;

    private void Awake()
    {
        position = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        position.x += _speed * Time.deltaTime;
        transform.position = position;
    }
}
