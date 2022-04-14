using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 8;
    public float jumpHeight = 7;
    float moveInput; //Значение с оси (-1; 1)
    public bool isGrounded = true;
    bool isRight = true; //Смотрит ли вправо
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
            isGrounded = false;
            animator.SetTrigger("takeOff");
        }

        if (isGrounded)
            animator.SetBool("isJumping", false);
        else
            animator.SetBool("isJumping", true);
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (!isRight && moveInput > 0) 
            Flip();
        else if (isRight && moveInput < 0) 
            Flip();

        if (moveInput == 0)
            animator.SetBool("isRunning", false);
        else
            animator.SetBool("isRunning", true);
    }

    void Flip()
    {
        isRight = !isRight;

        if (moveInput < 0)
            transform.eulerAngles = new Vector3(0, 180, 0);
        else
            transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
