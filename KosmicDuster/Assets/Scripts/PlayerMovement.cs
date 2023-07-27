using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMovement
{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    float horizontal;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2 (horizontal * playerSpeed, playerSpeed);
    }
}
}
