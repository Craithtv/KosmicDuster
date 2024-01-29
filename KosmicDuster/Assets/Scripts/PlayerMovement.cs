using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreCounter;

namespace Movement
{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    float horizontal;
    public int playerHp = 9;
    public int maxHealth = 10;
    public ScoreManager scoreManager;
    public GameObject aoeTrigger;
    public int scoreBoost = 10;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerHp = maxHealth;
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHp = Mathf.Clamp(playerHp, 0, maxHealth);
        MovePlayer();
        DeathCheck();
        

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
                //Debug.Log("hp down");
                Destroy(other.gameObject);
            }
    
            else if (other.gameObject.tag == "health")
            {
               // Debug.Log("hp up");
                playerHp++;
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "point")
            {
                scoreManager.currentScore += scoreBoost;
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "slow"){
                aoeTrigger.gameObject.SetActive(true);
            }
            else if (other.gameObject.tag == "laser")
            {
                //Debug.Log("enemy laser");
                playerHp--;
            }
    }

    private void OnCollisionEnter2D(Collision2D other) {
         if (other.gameObject.tag == "enemy")
            {
                //Debug.Log("enemy ship crash");
                playerHp--;
                Destroy(other.gameObject);
            }
    }
    
}
}
