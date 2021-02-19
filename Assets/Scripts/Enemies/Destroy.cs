using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    [SerializeField]
    private float _speed;
    protected float _size;
    protected float _positionX;
    private float _positionZ;
    private float _positionY;
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _positionZ = GetComponent<Transform>().position.z;
        _positionY = GetComponent<Transform>().position.y;
        _positionX = GetComponent<Transform>().position.x;
        _size = GetComponent<SpriteRenderer>().bounds.size.x;
        Destroy(gameObject, 4f);
    }

    private void Update()
    {
        Move();
    }

    // Update is called once per frame
    protected virtual void Move()
    {
        _positionX += _speed * Time.deltaTime;
        _transform.position = new Vector3(_positionX, _positionY, _positionZ);
    }

}
