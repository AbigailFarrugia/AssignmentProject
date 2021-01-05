using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float jumpForce;
    public float movementSpeed = 10f;
    public LayerMask GroundLayer;
	bool isGrounded;
    	Rigidbody2D rb; 
    public Transform groundCheck;
    float movement = 0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (isGrounded)
            {
                Jump();
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, GroundLayer);

    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
