using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public float startDelay = 5.0f;
    public float spawnInterval = 3.0f;
    public GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    private void SpawnRandomObject()
    {
        int index = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[index], transform);
    }
}
