using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBCSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _RBCPrefab;
    [SerializeField] private float _spawnInterval = 3;
    private float _timer = 0;
    
    void Update()
    {
        if (_timer > _spawnInterval)
        {
            Instantiate(_RBCPrefab, transform.position, transform.rotation);
            _timer = 0;
        }
        
        _timer += Time.deltaTime;
    }
}
