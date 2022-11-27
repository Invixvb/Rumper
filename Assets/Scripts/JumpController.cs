using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour {
	
	public float jumpVelocity;
	public Transform groundCheck;
	public LayerMask groundLayer;
	
	private Rigidbody2D rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	bool IsGrounded()
	{
		return Physics2D.OverlapBox(groundCheck.position, new Vector2( 1f, .5f), 0, groundLayer);
	}

	void Update()
	{
		if (Input.GetButtonDown("Jump") && IsGrounded())
		{
			rb.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
		}
	}
}
