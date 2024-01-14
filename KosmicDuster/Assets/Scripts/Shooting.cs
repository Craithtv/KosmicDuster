using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class Shooting : MonoBehaviour
    {
        public float attackSpeed;
        public GameObject[] weapon;
        private int currentWeaponIndex = 0;
        GameObject currentWeapon;
        private Rigidbody2D weaponRB;
        public Transform spawnPoint;
        public float coolDown = 5f;
        public float shotTimer;
        public bool hasShot = false;

        // Start is called before the first frame update
        void Start()
        {
            currentWeapon = weapon[currentWeaponIndex];
        }

        // Update is called once per frame
        void Update()
        {
            shotTimer -= Time.deltaTime;
            if (shotTimer <= 0.0f)
            {
                hasShot = true;
                shotTimer = coolDown;
            }

            if (Input.GetKey(KeyCode.Space))
            {//this requires space to be hit everytime. refactor to hold?
                if (hasShot == false) { return; }
                var weapon = Instantiate(currentWeapon, spawnPoint);
                hasShot = false;

                // weaponRB.AddForce(transform.forward*attackSpeed);
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                //this is to debug only, delete on build
                UpgradeWeapon();
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "weapon")
            {
                UpgradeWeapon();
                Destroy(other.gameObject); // Destroy the GameObject that contains the collider
            }
        }

        private void UpgradeWeapon()
        {
            currentWeaponIndex++;
            if (currentWeaponIndex >= weapon.Length)
            {
                currentWeaponIndex = 0;
            }
            currentWeapon = weapon[currentWeaponIndex];
           
        }
    }
}
