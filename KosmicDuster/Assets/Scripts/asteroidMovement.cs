using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 1;
    public int xMove = 1;
    public int yMove = -1;
    [SerializeField] int enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         DeathCheck();
        rb.velocity = new Vector2(xMove, yMove) * moveSpeed;
    }

    private void DeathCheck()
    {
        if (enemyHp <= 0)
        { Destroy(this.gameObject); }
    }

    void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag == "bullet")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
                Destroy(other.gameObject);
            }
        }
}
