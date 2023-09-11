using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private bool _isKeyNote;
    [SerializeField] private bool _isObstacle;
    [SerializeField] private GameObject obstacleVFX, keyNoteVFX;

    public Action OnKeyNoteHit;
    public Action OnObstacleHit;

    private void OnEnable()
    {
        OnKeyNoteHit += SpawnKeyNoteVFX;
        OnObstacleHit += SpawnKeyNoteVFX;
    }
    private void OnDisable()
    {
        OnKeyNoteHit -= SpawnKeyNoteVFX;
        OnObstacleHit -= SpawnObstacleVFX;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_isKeyNote)
            OnKeyNoteHit.Invoke();
        if(_isObstacle)
            OnObstacleHit.Invoke();
    }

    private void SpawnObstacleVFX()
    {
        var instance = Instantiate(obstacleVFX);

    }
    private void SpawnKeyNoteVFX()
    {
        var instance = Instantiate(keyNoteVFX);

    }
}
