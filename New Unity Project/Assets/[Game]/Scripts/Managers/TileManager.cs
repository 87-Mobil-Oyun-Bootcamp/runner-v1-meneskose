using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _tilePrefabs;
    private Transform _playerTransform;
    [SerializeField] private float _spawnZ = 0.0f;
    [SerializeField] private float _tileLength = 12.0f;
    [SerializeField] private int _amnTilesOnScreen = 7;
    private void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        SpawnTile();
        for (int i = 0; i < _amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (_playerTransform.position.z > (_spawnZ - _amnTilesOnScreen * _tileLength))
        {
            SpawnTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject gameobject;
        gameobject = Instantiate(_tilePrefabs [0]) as GameObject;
        gameobject.transform.SetParent(transform);
        gameobject.transform.position = Vector3.forward * _spawnZ;
        _spawnZ += _tileLength;
    }
}
