using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private bool isLeft;
    float distanceTravelled = 0;
    Vector3 lastPosition;
    public float jumpForce;
    public LayerMask GroundLayer;
    bool isGrounded;
    Rigidbody2D rb;
    public Transform groundCheck;
    public float movement = 3.5f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 velocity = rb.velocity;
        if (isGrounded)
        {
            velocity.x = 0f;
            rb.velocity = velocity;
        
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Jump();
                isLeft = false;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Jump();
                isLeft = true;
            }
        }

    }

    void FixedUpdate()
    {

        Vector2 velocity = rb.velocity;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, GroundLayer);

        distanceTravelled += Vector3.Distance(transform.position, lastPosition);

        lastPosition = transform.position;

        if (distanceTravelled >= 2f)
        {

            if (isLeft)
            {
                velocity.x = -movement;
                rb.velocity = velocity;
               // rb.AddForce(velocity);
            }
            else if (!isLeft)
            {
                velocity.x = movement;
                rb.velocity = velocity;
               // rb.AddForce(velocity);
            }
        }

        if (isGrounded)
        {
            distanceTravelled = 0;
        }
    }

    void Jump()
    {
        Vector2 velocity = rb.velocity;

        lastPosition = transform.position;

        rb.velocity = Vector2.up * jumpForce;
    }
}