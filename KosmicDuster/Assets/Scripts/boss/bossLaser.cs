using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossLaser : MonoBehaviour
{
     public Transform spawnPoint;
    public GameObject weapon;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
    public timeManager timeManager;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = this.gameObject.transform;
        timeManager = FindObjectOfType<timeManager>();
    }

    // Update is called once per frame
    void Update()
    {    currentTime += Time.deltaTime;
         
         if (!timeManager.isSlow){ enemyShoot();}
       
    }

    public void enemyShoot(){
       
       
        if (currentTime > nextFire){
            nextFire += currentTime;
            var wep =Instantiate (weapon, spawnPoint.position, weapon.transform.rotation);
            wep.transform.parent = gameObject.transform;
            nextFire -= currentTime;
            currentTime = 0.0f;
            
        }
    }
}
