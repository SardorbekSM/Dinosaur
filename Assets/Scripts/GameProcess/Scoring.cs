using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private int _score;
    private Text _scoreText;

    [SerializeField]
    private int _calcAccuracy = 10;

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        ++_score;
        _scoreText.text = (_score / _calcAccuracy).ToString();
    }
}