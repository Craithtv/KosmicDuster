using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D bulletRB;
    public float attackSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    
        bulletRB.AddForce(transform.forward*attackSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
