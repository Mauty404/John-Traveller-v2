
using Unity.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //[SerializeField]
    //public GameObject characterPrefab;
   // [SerializeField]
    public float respawnTime = 3f;

    public int amount = 3;
    public GameObject[] characterPrefabs;
    
 
    float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + respawnTime;
            GameObject clone = Instantiate(characterPrefabs[(int)Random.Range(0f,(float)characterPrefabs.Length)], transform.position, transform.rotation) as GameObject;
        }
    }
}
