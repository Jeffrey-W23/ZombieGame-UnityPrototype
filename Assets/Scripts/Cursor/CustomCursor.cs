using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
	public Texture2D cursor;

	// Use this for initialization
	void Start()
    {
		Vector2 cursorHotspot = new Vector2(cursor.width / 2, cursor.height / 2);
		Cursor.SetCursor(cursor, cursorHotspot, CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update()
    {

    }
}