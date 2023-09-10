using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBlock : MonoBehaviour
{
    [SerializeField] private Entity _keyNotePrefab;
    [SerializeField] private Entity _obstaclePrefab;
    
    private SongManager _songManager;
    private List<GameObject> _lanes = new List<GameObject>();
    private int _spawnedKeyNoteLane;

    private void OnEnable()
    {
        _songManager = FindAnyObjectByType<SongManager>();

        foreach(GameObject lane in transform)
        {
            _lanes.Add(lane);
        }

        if(_songManager != null)
        {
            _songManager.SpawnKeyNote += SpawnKeyNote;
            _songManager.SpawnKeyNote += SpawnObstacle;
        }
        
    }

    private void OnDestroy()
    {
        if (_songManager != null)
        {
            _songManager.SpawnKeyNote -= SpawnKeyNote;
            _songManager.SpawnKeyNote -= SpawnObstacle;
        }
    }

    private void SpawnKeyNote()
    {
        var randomLane = GetRandomeLane();
        Instantiate(_keyNotePrefab, _lanes[randomLane].transform);
        _spawnedKeyNoteLane = randomLane;
    }

    private void SpawnObstacle()
    {
        var randomLane = GetRandomeLane();
        if (randomLane != _spawnedKeyNoteLane)
        {
            Instantiate(_obstaclePrefab, _lanes[randomLane].transform);
        }
        else
            SpawnObstacle();
    }

    private int GetRandomeLane()
    {
        return Random.Range(0, _lanes.Count);
    }
}
