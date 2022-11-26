using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Animator animator;
    private float moveInput;
    private bool facingRight = true;
    private static readonly int Speed = Animator.StringToHash("Speed");

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (rb.velocity.x == 0)
        {
            animator.SetFloat(Speed, 0);
        }
        else
        {
            animator.SetFloat(Speed, 1);
        }

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

        if (rb.position.y < -75f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}