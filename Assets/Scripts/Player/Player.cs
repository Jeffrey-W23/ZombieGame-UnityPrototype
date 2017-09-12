using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Player speed.
	public float m_fspeed = 0.002f;

	// Get rigid
	Rigidbody2D m_rb;

	// Use this for initialization
	void Awake()
	{
        m_rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		float fHor = Input.GetAxis("Horizontal");
		float fVer = Input.GetAxis("Vertical");

		if (fVer > 0)
		{
            m_rb.velocity += Vector2.up * m_fspeed * Time.fixedDeltaTime;
		}

		if (fVer < 0)
		{
            m_rb.velocity -= Vector2.up * m_fspeed * Time.fixedDeltaTime;
		}

		if (fHor < 0)
		{
            m_rb.velocity -= Vector2.right * m_fspeed * Time.fixedDeltaTime;
		}

		if (fHor > 0)
		{
            m_rb.velocity += Vector2.right * m_fspeed * Time.fixedDeltaTime;
		}

		if (fHor == 0 && fVer == 0)
		{
			Vector2 vel = m_rb.velocity;

			if (m_rb.velocity.x > 0)
				vel.x -= 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.x < 0)
				vel.x += 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.y > 0)
				vel.y -= 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.y < 0)
				vel.y += 0.7f * Time.fixedDeltaTime;

			
			if (vel.magnitude < 0.01f)
				vel = Vector2.zero;

			m_rb.velocity = vel;
		}

		if (Input.GetKey(KeyCode.Escape))
		{
            Application.Quit();
		}

        // Rotation
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
