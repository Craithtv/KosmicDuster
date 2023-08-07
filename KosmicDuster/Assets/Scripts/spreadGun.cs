using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spreadGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {//this requires space to be hit everytime. refactor to hold?

           GameObject bullet1 = Instantiate(bullet, spawnPoint);
            GameObject bullet2 = Instantiate(bullet, spawnPoint);
                Rigidbody2D bullet2rb = bullet2.GetComponent<Rigidbody2D>();
                bullet2.transform.Translate(Vector3.left * Time.deltaTime * speed * 1);
            GameObject bullet3 = Instantiate(bullet, spawnPoint);
            Rigidbody2D bullet3rb = bullet3.GetComponent<Rigidbody2D>();


        }
    }
}
