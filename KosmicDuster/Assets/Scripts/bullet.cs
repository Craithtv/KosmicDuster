using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D bulletRB;
    public float attackSpeed = 10f;
    public float xMove = 1;
    public float yMove = -1;
    public float currentTime;
      public float decayTime;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        bulletRB.velocity = new Vector2(xMove, yMove) * attackSpeed;

        if (currentTime > decayTime)
        {
            Destroy(this.gameObject);
        }

    }

}
