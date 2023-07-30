using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedDown : MonoBehaviour
{   
    public timeManager timeManager;

    private void Start() {
       timeManager = FindObjectOfType<timeManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            timeManager.isSlow = true;
            Destroy(this.gameObject);
        }
    }
   
}