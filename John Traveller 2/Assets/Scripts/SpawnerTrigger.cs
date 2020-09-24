using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
    bool activated = false;
    EnemySpawner _enemySpawner;
    GameObject _spawnerObj;
    private void Start()
    {
        _spawnerObj = transform.parent.gameObject;
        //_spawnerObj = GameObject.Find("Spawner");
        _enemySpawner = _spawnerObj.GetComponent<EnemySpawner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!activated)
        {
            _enemySpawner.enabled = true;
            activated = true;
        }
        
    }
}
