// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// FollowPlayer object. Inheriting from MonoBehaviour
//--------------------------------------------------------------------------------------
public class FollowPlayer : MonoBehaviour
{
    // Public Gameobject for the target the camera is to follow.
    public GameObject m_tTarget;

	// offset value
	private Vector3 m_v3Offset;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake() 
    {
        // set the offset value.
        m_v3Offset = transform.position - m_tTarget.transform.position;
    }

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update()
    {
        // Calc the new x and y position of the camera
        float fNewXPosition = m_tTarget.transform.position.x - m_v3Offset.x;
        float fNewYPosition = m_tTarget.transform.position.y - m_v3Offset.y;

        // Update the postion.
        transform.position = new Vector3(fNewXPosition, fNewYPosition, transform.position.z);
    }	
}
