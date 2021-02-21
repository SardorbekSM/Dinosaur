using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    private int score;
    private Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        ++score;
        _scoreText.text = Convert.ToString(score/10);
    }
}