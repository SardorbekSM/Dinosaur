using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    protected Vector3 position;

    [SerializeField]
    protected Transform _transform;


    private void Awake()
    {
        _transform = GetComponent<Transform>();
        position = _transform.position;
    }

    protected virtual void Move()
    {
        position.x += _speed * Time.deltaTime;        
        _transform.position = position;
    }
}
