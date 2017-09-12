using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : MonoBehaviour
{
	Rigidbody2D m_rb;
	Vector2 dir;
	public float m_fSpeed = 15;

	// Use this for initialization
	void Awake()
    {
		m_rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
		transform.right = dir;
		m_rb.velocity = (dir * m_fSpeed * Time.fixedDeltaTime);
		m_rb.angularVelocity = 0;
	}

	public void SetDir(Vector2 v)
	{
		dir = v;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		gameObject.SetActive(false);
	}
}
