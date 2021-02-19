using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : Movement
{
    private void Update()
    {
        Repeat();
    }

    private void Repeat()
    {
        _positionX = Mathf.Repeat(_positionX, _size);
        Move();
    }
}
