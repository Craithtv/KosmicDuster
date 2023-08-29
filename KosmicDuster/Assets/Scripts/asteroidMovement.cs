using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreCounter;

public class asteroidMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 10;
    public int xMove = 1;
    public int yMove = -1;
    [SerializeField] int enemyHp;
    public ScoreManager scoreManager;
    public timeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        timeManager = FindObjectOfType<timeManager>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
         DeathCheck();
         if (!timeManager.isSlow)
        {rb.velocity = new Vector2(xMove, yMove) * moveSpeed;}
        if (timeManager.isSlow)
                {
                Debug.Log("Slow");
                rb.gravityScale = 0;
                rb.velocity = new Vector2 (0, 0);
                }
    }

    private void DeathCheck()
    {
        if (enemyHp <= 0)
        { 
            scoreManager.currentScore++;
            GetComponent<lootBag>().InstantiateLoot(transform.position);
            
            Destroy(this.gameObject); 
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag == "bullet")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
                Destroy(other.gameObject);
            }
            if(other.gameObject.tag == "laser")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
            }
        }
}
