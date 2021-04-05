using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    protected Vector3 position;

    private void Start()
    {
        position = transform.position;
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        position.x += _speed * Time.deltaTime;
        transform.position = position;
    }
}
