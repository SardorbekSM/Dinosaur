using UnityEngine;

public class ByXPositionRepeater : Movement
{
    private float _size;

    private void Awake()
    {
        _size = GetComponent<SpriteRenderer>().bounds.size.x;
        position = transform.position;
    }

    private void Update()
    {
        Repeat();
    }

    private void Repeat()
    {
        position.x = Mathf.Repeat(transform.position.x, _size);
        Move();
    }
}
