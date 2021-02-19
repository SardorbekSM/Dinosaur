using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private float _position;
    private float _size;
    private float _positionZ;
    private float _positionY;
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _positionZ = GetComponent<Transform>().position.z;
        _positionY = GetComponent<Transform>().position.y;
        _size = GetComponent<SpriteRenderer>().bounds.size.x; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        _position += _speed * Time.deltaTime;
        _position = Mathf.Repeat(_position, _size);
        _transform.position = new Vector3(_position, _positionY, _positionZ);
    }
}
