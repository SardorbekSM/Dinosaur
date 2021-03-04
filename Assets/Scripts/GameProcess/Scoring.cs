using UnityEngine;
using UnityEngine.UI;
using System;

public class Scoring : MonoBehaviour
{
    private int _score;
    private Text _scoreText;
    private int _calcAccuracy = 10;

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        ++_score;
        _scoreText.text = Convert.ToString(_score/_calcAccuracy);
    }
}