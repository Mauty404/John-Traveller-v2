using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
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
        _enemySpawner.enabled = true;
    }
}
