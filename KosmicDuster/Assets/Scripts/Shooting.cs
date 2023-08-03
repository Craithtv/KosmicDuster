using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
public class Shooting : MonoBehaviour
{
    public float attackSpeed;
    public GameObject [] weapon;
    private int currentWeaponIndex = 0;
    GameObject currentWeapon;
    private Rigidbody2D weaponRB;
    public Transform spawnPoint;

        // Start is called before the first frame update
        void Start()
    {
       currentWeapon = weapon[currentWeaponIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {//this requires space to be hit everytime. refactor to hold?

            Instantiate(currentWeapon, spawnPoint);
            // weaponRB.AddForce(transform.forward*attackSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "weapon"){
          for (int i = 0; i < weapon.Length; i++){
            i++;
          }
          currentWeapon = weapon[currentWeaponIndex];
        }
        
    }
}
}
