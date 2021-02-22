using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    private int _score;
    private Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        ++_score;
        _scoreText.text = Convert.ToString(_score/10);
    }
}