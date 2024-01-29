using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeCheck : MonoBehaviour
{
    public GameObject enemy;
    private enemyShooting enemyShooting;

    private void Start() {
        enemyShooting = enemy.GetComponent<enemyShooting>();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            enemyShooting.inRange = true;
            Debug.Log("Contact");
        }
    }

}
