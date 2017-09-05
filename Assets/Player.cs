using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Player speed.
	public float m_fspeed = 0.002f;

	// Get rigid
	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			 rb.velocity += Vector2.up * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.S))
		{
			rb.velocity -= Vector2.up * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.A))
		{
			rb.velocity -= Vector2.right * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.D))
		{
			rb.velocity += Vector2.right * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
