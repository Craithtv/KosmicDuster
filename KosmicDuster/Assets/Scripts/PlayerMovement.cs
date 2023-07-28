using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movement
{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    float horizontal;
    public int playerHp = 10;
    public int maxHealth = 10;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerHp = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        DeathCheck();
        playerHp = Mathf.Clamp(playerHp, 0, maxHealth);

        if(Input.GetKeyDown(KeyCode.H))
        {
            playerHp++;
            //just to test hp restore ui
        }
    }
    private void DeathCheck()
    {
        if (playerHp <= 0)
        { Destroy(this.gameObject); }
    }

    void MovePlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2 (horizontal * playerSpeed, playerSpeed);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
            if(other.gameObject.tag == "enemyBullet")
            {//only works for 1 damage bullets. refactor for charge shots
                playerHp--;
                Destroy(other.gameObject);
            }
        
            else if (other.gameObject.tag == "enemy")
            {
                playerHp--;
                Destroy(other.gameObject);
            }
    }
}
}
