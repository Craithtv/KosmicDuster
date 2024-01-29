using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreCounter;

public class boss_move : MonoBehaviour
{
    Rigidbody2D rb;
    //Transform player;
    public float moveSpeed = 3f;
    public float attackRange = 7f;
    
    public bool movingRight = true;


    private void Awake() 
    {
      //scoreManager = FindObjectOfType<ScoreManager>();
      rb = GetComponent<Rigidbody2D>();
    }

  private void Update() 
  {
    if (movingRight == true)
    {
      rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    if (!movingRight)
    {
      rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }
  }

  private void OnTriggerEnter2D(Collider2D other) 
 {
    if (movingRight)
    {
      movingRight = false;
    }
    else
    {
      movingRight = true;
    }
 }
}
