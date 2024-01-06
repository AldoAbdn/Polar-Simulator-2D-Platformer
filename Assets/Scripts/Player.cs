using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpPower = 10;
    public int movementPower = 10;
    public bool isJumping = false;

    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Right
        if(Input.GetKeyDown(KeyCode.D)) 
        {  
            spriteRenderer.flipX = false;
            rigidBody.velocity = Vector2.right * movementPower;
        }
        // Left
        else if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            rigidBody.velocity = Vector2.left * movementPower;
        }
        // Jump
        else if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            isJumping = true;
            rigidBody.velocity = Vector2.up * jumpPower;
        }
        // Shoot
        else if(Input.GetKeyDown (KeyCode.Space)) 
        { 
            // Spawn Bullet
        }
    }
}
