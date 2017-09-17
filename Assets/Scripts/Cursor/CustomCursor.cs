// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// CustomCursor object. Inheriting from MonoBehaviour
//--------------------------------------------------------------------------------------
public class CustomCursor : MonoBehaviour
{
    // Public texture for the cursor visuals.
	public Texture2D m_TCursor;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake()
    {
        // Set the mouse click point.
		Vector2 v2CursorHotspot = new Vector2(m_TCursor.width / 2, m_TCursor.height / 2);

        // Set the cursor values.
        Cursor.SetCursor(m_TCursor, v2CursorHotspot, CursorMode.Auto);
	}

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update()
    {

    }
}