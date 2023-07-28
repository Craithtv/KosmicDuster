using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
     public float currentTime;
public float spawnInterval = 2.0f; // Adjust this value to set the time between spawns
public GameObject meteor;
public Transform[] spawnPos;
public Transform spawn;

// Update is called once per frame
void Update()
{
    spawn = spawnPos[Random.Range(0, spawnPos.Length)];
    SpawnTimer();
}

private void SpawnTimer()
{
    currentTime += Time.deltaTime;
    if (currentTime > spawnInterval)
    {
        Instantiate(meteor, spawn.position, Quaternion.identity);
        currentTime -= spawnInterval; // Subtract spawnInterval from currentTime, not nextSpawn
    }
}
        }
    
