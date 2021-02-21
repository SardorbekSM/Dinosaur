﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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