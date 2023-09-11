using System;
using UnityEngine;
using TMPro;

public class Entity : MonoBehaviour
{
    [SerializeField] private bool _isKeyNote;
    [SerializeField] private bool _isObstacle;
    [SerializeField] private GameObject obstacleVFX, keyNoteVFX;
    [SerializeField] private AudioSource _hitKeySFX;
    [SerializeField] private AudioSource _missKeySFX;
    [SerializeField] private AudioSource _hitObstacleSFX;

    public Action OnKeyNoteHit;
    public Action OnObstacleHit;

    private ScoreManager _scoreManager;

    private void OnEnable()
    {
        OnKeyNoteHit += PlayKeyNoteSFXAndVFX;
        OnObstacleHit += PlayObstacleSFXAndVFX;
        _scoreManager = FindAnyObjectByType<ScoreManager>();
    }
    private void OnDisable()
    {
        OnKeyNoteHit -= PlayKeyNoteSFXAndVFX;
        OnObstacleHit -= PlayObstacleSFXAndVFX;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_isKeyNote)
            OnKeyNoteHit.Invoke();
        if(_isObstacle)
            OnObstacleHit.Invoke();
    }

    private void PlayObstacleSFXAndVFX()
    {
        if(obstacleVFX != null)
        {
            Instantiate(obstacleVFX, transform);
            _hitObstacleSFX.Play();
            _scoreManager._removeFromScore.Invoke(-10000000000);
        }
    }

    private void PlayKeyNoteSFXAndVFX()
    {
        if(keyNoteVFX != null)
        {
            Instantiate(keyNoteVFX);
            _hitKeySFX.Play();
            _scoreManager._addToScore.Invoke(1);
        }
    }
}
