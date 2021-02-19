using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    protected Vector3 position;

    [SerializeField]
    private Transform _transform;


    private void Awake()
    {
        _transform = GetComponent<Transform>();
        position = _transform.position;
    }

    // Update is called once per frame
    protected virtual void Move()
    {
        position.x += _speed * Time.deltaTime;
        _transform.position = position;
    }
}
