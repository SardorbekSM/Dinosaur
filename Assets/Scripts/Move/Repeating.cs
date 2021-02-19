using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : Movement
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
