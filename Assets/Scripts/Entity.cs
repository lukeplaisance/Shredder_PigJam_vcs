using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private bool _isKeyNote;
    [SerializeField] private bool _isObstacle;

    public Action OnKeyNoteHit;
    public Action OnObstacleHit;

    private void OnTriggerEnter(Collider other)
    {
        if (_isKeyNote)
            OnKeyNoteHit.Invoke();
        if(_isObstacle)
            OnObstacleHit.Invoke();
    }
}
