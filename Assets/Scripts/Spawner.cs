using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnRate = 3;
    float spawnTime;

    void Start()
    {
        spawnTime = spawnRate; 
    }
    void Update()
    {
        if (spawnTime < 0)
        {
            GameObject newBall = Instantiate(prefabToSpawn);
            newBall.transform.position = transform.position;
            spawnTime = spawnRate;
        }

        spawnTime -= Time.deltaTime;
    }
 }
