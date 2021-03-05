using UnityEngine;

public class ByXPositionRepeater : Movement
{
    private float _boundSize;

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
}
