using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public float minSpawnInterval = 2.0f;
    public float maxSpawnInterval = 4.0f;
    public GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        float spawnDelay = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomObject", spawnDelay);
    }

    private void SpawnRandomObject()
    {
        int index = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[index], transform);
        
        float spawnDelay = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomObject", spawnDelay);
    }
}
