// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    // float for the distance between mouse and object.
    float m_fDistanceBetween;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake()
    {
		
	}

    //--------------------------------------------------------------------------------------
    // LateUpdate: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void LateUpdate()
    {
        // Get mouse inside camera
		Vector3 v3Pos1 = Camera.main.WorldToScreenPoint(transform.position);

        // update the distance.
        m_fDistanceBetween = Vector3.Distance(v3Pos1, Input.mousePosition);

        // Check the distance between the mouse and arm.
        // if far enough away turn the mouse towards mouse.
        // else stop arm rotation.
        if (m_fDistanceBetween > 100)
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
}
