using UnityEngine;

public class ByXPositionRepeater : MonoBehaviour
{

    [SerializeField]
    private float _speed;

    private float _boundSize;

    private Vector3 position;

    private void Awake()
    {
        _boundSize = GetComponent<SpriteRenderer>().bounds.size.x;
        position = transform.position;
    }

    private void Update()
    {
        Repeat();
    }

    private void Repeat()
    {
        position.x = Mathf.Repeat(transform.position.x, _boundSize);
        Move();
    }


    protected virtual void Move()
    {
        position.x += _speed * Time.deltaTime;
        transform.position = position;
    }
}
