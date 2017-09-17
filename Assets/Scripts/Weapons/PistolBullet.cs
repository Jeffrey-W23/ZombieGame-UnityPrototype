// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// PistolBullet object. Inheriting from MonoBehaviour
//--------------------------------------------------------------------------------------
public class PistolBullet : MonoBehaviour
{
    // New rigidbody
    Rigidbody2D m_rb;

    // Vector2 for bullet direction.
	Vector2 m_v2Dir;

    // Public float for the bullet speed.
	public float m_fSpeed = 15;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake()
    {
        // Get bullet Rigidbody
        m_rb = GetComponent<Rigidbody2D>();
	}

    //--------------------------------------------------------------------------------------
    // FixedUpdate: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void FixedUpdate()
    {
        // Update the bullets velocity, direction etc.
        transform.right = m_v2Dir;
		m_rb.velocity = (m_v2Dir * m_fSpeed * Time.fixedDeltaTime);
		m_rb.angularVelocity = 0;
	}

    //--------------------------------------------------------------------------------------
    // SetDir: Direction setter fot the bullet.
    //
    // Param:
    //      v: a Vector2 for the direction to set.
    //--------------------------------------------------------------------------------------
    public void SetDir(Vector2 v)
	{
        // Update direction.
        m_v2Dir = v;
	}

    //--------------------------------------------------------------------------------------
    // OnCollisionEnter2D: When this object collides with another object call this function.
    //
    // Param:
    //      collision: a Collision2D for what object has had a collision.
    //--------------------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
	{
        // Set to inactive on collision.
		gameObject.SetActive(false);
	}
}
