using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;
	private float moveInput;

	private bool facingRight = true;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		moveInput = Input.GetAxisRaw("Horizontal");
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

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
