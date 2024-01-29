using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemyShip;
    public float timeToSpawn = 2f;
    public float currentTime = 0.0f;
    public Transform spawnPoint; 
    public patrolRouteManager patrolRouteManager;



    // Start is called before the first frame update
    void Start()
    {
        patrolRouteManager = FindObjectOfType<patrolRouteManager>();
    }

    // Update is called once per frame
    void Update()
    {
                currentTime += Time.deltaTime;

                if(currentTime >= timeToSpawn)
                {
                    Instantiate (enemyShip, spawnPoint.position, Quaternion.identity);
                    currentTime = 0.0f;
                }

    }
}
