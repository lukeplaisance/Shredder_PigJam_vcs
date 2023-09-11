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

        int i = 0;
        foreach (var lane in transform)
        {
            var child = transform.GetChild(i);
            _lanes.Add(child.gameObject);
        }

        if (_songManager != null)
            _songManager.SpawnKeyNote += CallSpawnCoroutine;

    }

    private void OnDestroy()
    {
        if (_songManager != null)
            _songManager.SpawnKeyNote -= CallSpawnCoroutine;
    }

    private void SpawnKeyNote(float zposition)
    {
        var randomLane = GetRandomeLane();
        var newPosition = new Vector3(_lanes[randomLane].transform.position.x, _lanes[randomLane].transform.position.y, zposition);
        Instantiate(_keyNotePrefab, newPosition, Quaternion.identity);
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

    private void CallSpawnCoroutine(float newPos)
    {
        StartCoroutine(SpawnKeyAndObstacle(newPos));
    }

    private IEnumerator SpawnKeyAndObstacle(float newPos)
    {
        SpawnKeyNote(newPos);
        yield return null;
        SpawnObstacle();
    }
}
