using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemySpaceBuffer : MonoBehaviour
{
   public Rigidbody2D rb;


    void Start()
    {
        
    }

 
    void OnTriggerEnter2D(Collider2D other) 
    {
        
            if (other.gameObject.tag == "enemy")
            {
                
            }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        
    }

    
}
