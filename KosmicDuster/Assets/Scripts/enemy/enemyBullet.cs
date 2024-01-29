using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    
      public Rigidbody2D bulletRB;
      public float currentTime;
      public float decayTime;
    public float attackSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = this.gameObject.GetComponent<Rigidbody2D>();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        bulletRB.velocity = new Vector2(0,-1) * attackSpeed;

        if (currentTime > decayTime)
        {
            Destroy(this.gameObject);
        }
    }
}

