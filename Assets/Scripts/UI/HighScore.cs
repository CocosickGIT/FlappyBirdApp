using System;
using TMPro;
using UnityEngine;

namespace UI
{
    public class HighScore : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _counter;
        [SerializeField] private TextMeshProUGUI _highScoreText;

        private int _highScore;
        
        private void Start()
        {
            _highScore = PlayerPrefs.GetInt("HighScore", 0);
            _highScoreText.text = $"High Score: {_highScore}";
        }

        private void Update()
        {
            HighScoreUpdate();
        }

        private void HighScoreUpdate()
        {
            var currentScore = _counter.ScoreCount;
            if (currentScore <= _highScore) return;
            
            PlayerPrefs.SetInt("HighScore", currentScore);
            _highScoreText.text = $"High Score: {currentScore}";
        }
    }
}
