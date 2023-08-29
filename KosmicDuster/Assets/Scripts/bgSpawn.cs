using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSpawn : MonoBehaviour
{

    public GameObject bg;
    public Transform bgSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Respawn")
        {
            Debug.Log("bg hit");
            Destroy(other.gameObject);
            Instantiate(bg, bgSpawnPoint);
        }
    }
}
