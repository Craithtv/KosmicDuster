using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeCheck : MonoBehaviour
{
    public GameObject enemy;
    private enemyShooting enemyShooting;
    private enemyShipPath enemyShipPath;

    private void Start() {
        enemyShooting = enemy.GetComponent<enemyShooting>();
        enemyShipPath = enemy.GetComponent<enemyShipPath>();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            enemyShooting.inRange = true;
            Debug.Log("Contact");
        }

        else if (other.tag == "enemy")
        {
            enemyShipPath.moveSpeed = 0.0f;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if (other.tag == "enemy")
        {
        enemyShipPath.moveSpeed = 2f;
        }
    }

}
