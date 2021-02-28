using UnityEngine;

public class Repeater : Movement
{
    private float size;

    private void Start()
    {
        size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Repeat();
    }

    protected void Repeat()
    {
        position.x = Mathf.Repeat(position.x, size);
        Move();
    }
}
