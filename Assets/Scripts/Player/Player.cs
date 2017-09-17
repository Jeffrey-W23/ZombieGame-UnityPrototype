// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// Player object. Inheriting from MonoBehaviour
//--------------------------------------------------------------------------------------
public class Player : MonoBehaviour
{
	// Public Player speed.
	public float m_fspeed = 0.002f;

	// New rigidbody.
	Rigidbody2D m_rb;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake()
	{
        // Get player Rigidbody
        m_rb = GetComponent<Rigidbody2D>();
	}

    //--------------------------------------------------------------------------------------
    // FixedUpdate: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void FixedUpdate()
	{
        // Get the Horizontal and Vertical axis.
		float fHor = Input.GetAxis("Horizontal");
		float fVer = Input.GetAxis("Vertical");

        // if Vertical axis is pushed up.
		if (fVer > 0)
		{
            // Move player up.
            m_rb.velocity += Vector2.up * m_fspeed * Time.fixedDeltaTime;
		}

        // if Vertical axis is pushed down.
        if (fVer < 0)
   		{
            // Move player down.
            m_rb.velocity -= Vector2.up * m_fspeed * Time.fixedDeltaTime;
		}

        // if Horizontal axis is pushed left.
        if (fHor < 0)
		{
            // Move player left.
            m_rb.velocity -= Vector2.right * m_fspeed * Time.fixedDeltaTime;
		}

        // if Horizontal axis is pushed right.
        if (fHor > 0)
		{
            // Move player right.
            m_rb.velocity += Vector2.right * m_fspeed * Time.fixedDeltaTime;
		}






        // SORT
		if (fHor == 0 && fVer == 0)
		{
			Vector2 v2Vel = m_rb.velocity;

			if (m_rb.velocity.x > 0)
                v2Vel.x -= 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.x < 0)
                v2Vel.x += 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.y > 0)
                v2Vel.y -= 0.7f * Time.fixedDeltaTime;

			if (m_rb.velocity.y < 0)
                v2Vel.y += 0.7f * Time.fixedDeltaTime;

			
			if (v2Vel.magnitude < 0.01f)
                v2Vel = Vector2.zero;

			m_rb.velocity = v2Vel;
		}
        // SORT






        // If esc button is pressed exit application.
        if (Input.GetKey(KeyCode.Escape))
		{
            Application.Quit();
		}

        // rotate player based on mouse postion.
        Roatate();
    }

    //--------------------------------------------------------------------------------------
    // Roatate: Rotate the player from the mouse movement.
    //--------------------------------------------------------------------------------------
    void Roatate()
    {
        // Get mouse inside camera 
        Vector3 v3Pos = Camera.main.WorldToScreenPoint(transform.position);

        // Get the  mouse direction.
        Vector3 v3Dir = Input.mousePosition - v3Pos;

        // Work out the angle.
        float fAngle = Mathf.Atan2(v3Dir.y, v3Dir.x) * Mathf.Rad2Deg;

        // Update the rotation.
        transform.rotation = Quaternion.AngleAxis(fAngle, Vector3.forward);
    }
}
