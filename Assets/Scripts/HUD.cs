using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private ScoreManager _scoreManager;

    private void OnEnable()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();

        _scoreManager._addToScore.AddListener(UpdateScoreText);
        _scoreManager._removeFromScore.AddListener(UpdateScoreText);
    }

    private void UpdateScoreText(float newScore)
    {
        if(newScore < 0)
            newScore = 0;

        _scoreText.text += newScore.ToString();
    }
}
