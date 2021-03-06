﻿using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;

    [SerializeField]
    private float _height;

    [SerializeField]
    private float _positionX = 10;

    [SerializeField]
    private float _randomFrom = 3f;

    [SerializeField]
    private float _randomTo = 5f;

    private Vector3 _startPostion;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        _startPostion = new Vector3(_positionX, _height, 0);

        while (true)
        {
            Instantiate(_enemy, _startPostion, Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(Random.Range(_randomFrom, _randomTo));
        }
    }
}
