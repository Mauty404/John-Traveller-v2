
using Unity.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //[SerializeField]
    //public GameObject characterPrefab;
   // [SerializeField]
    public float respawnTime = 3f;
    public int amountOfEnemies = 3;
    public GameObject[] characterPrefabs;

    public GameObject boss;

    float counter;
    
    
 
    float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime && counter < amountOfEnemies)
        {
            nextSpawnTime = Time.time + respawnTime;
            GameObject clone = Instantiate(characterPrefabs[(int)Random.Range(0f,(float)characterPrefabs.Length)], transform.position, transform.rotation) as GameObject;
            if (counter == amountOfEnemies - 1)
                CreateBoss();
            counter++;
        }
    }

    void CreateBoss()
    {
        GameObject clone = Instantiate(boss, transform.position, transform.rotation) as GameObject;
    }
}
