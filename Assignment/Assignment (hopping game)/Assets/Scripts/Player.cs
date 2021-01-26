using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private float safePos;
    private float fallingDistance;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //right & left movement
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

        if (safePos > transform.position.y)
        {
            fallingDistance = safePos - transform.position.y;
            if (fallingDistance > 1.5f)
            {
                GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Platform");

                foreach (GameObject obj in allObjects)
                {
                    Destroy(obj);

                }
            }
            if (fallingDistance > 6f)
            {
                RestartLevel();
            }
        }

        if (isGrounded)
        {
            safePos = transform.position.y;
            distanceTravelled = 0;
        }
    }

    void Jump()
    {
        Vector2 velocity = rb.velocity;
        rb.velocity = Vector2.up * jumpForce;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }



    public void StillOnPlatform()
    {
        //_sittingOnPlatform
    }
}