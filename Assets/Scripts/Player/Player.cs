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
	void Start()
	{
        m_rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
            m_rb.velocity += Vector2.up * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.S))
		{
            m_rb.velocity -= Vector2.up * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.A))
		{
            m_rb.velocity -= Vector2.right * m_fspeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.D))
		{
            m_rb.velocity += Vector2.right * m_fspeed * Time.deltaTime;
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
