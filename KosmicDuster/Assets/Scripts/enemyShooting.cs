using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject weapon;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = this.gameObject.transform;
     
    }

    // Update is called once per frame
    void Update()
    {
        enemyShoot();
    }

    public void enemyShoot(){
        currentTime += Time.deltaTime;
        
        if (currentTime > nextFire){
            nextFire += currentTime;
            var wep =Instantiate (weapon, spawnPoint.position, weapon.transform.rotation);
            wep.transform.parent = gameObject.transform;
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}
