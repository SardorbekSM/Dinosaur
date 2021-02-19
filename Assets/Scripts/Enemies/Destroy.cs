using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Destroy : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    protected Vector3 position;
    private Transform _transform;

    // Start is called before the first frame update
    private void Start()
    {
        _transform = GetComponent<Transform>();
        position = _transform.position; 
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    protected virtual void Move()
    {
        position.x += _speed * Time.deltaTime;
        _transform.position = position;
    }

}
*/

public class Destroy : Movement
{
    [SerializeField]
    private float _destroyTime;

    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }

    private void Update()
    {
        Move();
    }
}