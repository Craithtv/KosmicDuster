using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject weaponPrefab;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
    public timeManager timeManager;


    // Start is called before the first frame update
    void Start()
    {
        timeManager = FindObjectOfType<timeManager>();
    }

    // Update is called once per frame
    void Update()
    {
         
         if (!timeManager.isSlow){enemyShoot();}
       
    }

    public void enemyShoot(){
       
        currentTime += Time.deltaTime;

        if (currentTime >= nextFire){
            //nextFire += currentTime;
            GameObject bullet = Instantiate (weaponPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
            bulletRb.velocity = spawnPoint.up.normalized * 10f;
            //wep.transform.parent = gameObject.transform;
            currentTime = 0.0f;
            
        }
    }
}
