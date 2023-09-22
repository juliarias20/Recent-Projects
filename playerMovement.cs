using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float moveDirection;
    public float jumpForce;
    private bool isJumping = false;
    private bool facingRight = true;

    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    private bool isGrounded;
    public float checkRadius;
    private int jumpCount;
    public int maxJumpCount;

    private Rigidbody2D rb;

    private void Start()
    {
        jumpCount = maxJumpCount;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);
        if (isGrounded)
        {
            jumpCount = maxJumpCount;
        }
        Move();
    }
    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

        Animate();

    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        
    }

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
            jumpCount--;
        }
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }

        else if ( moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;

        transform.Rotate(0,100,0);
    }
}
