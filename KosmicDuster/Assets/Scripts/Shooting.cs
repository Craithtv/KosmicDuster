using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
public class Shooting : MonoBehaviour
{
    public float attackSpeed;
    public GameObject weapon;
    private Rigidbody2D weaponRB;
    public Transform spawnPoint;

        // Start is called before the first frame update
        void Start()
    {
        // weaponRB = weapon.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {//this requires space to be hit everytime. refactor to hold?

            Instantiate(weapon, spawnPoint);
            // weaponRB.AddForce(transform.forward*attackSpeed);
        }
    }
}
}
