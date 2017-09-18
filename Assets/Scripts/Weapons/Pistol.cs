// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// Pistol object. Inheriting from MonoBehaviour
//--------------------------------------------------------------------------------------
public class Pistol : MonoBehaviour {

    // Public gameobject for bullet object.
	public GameObject m_gBlueprint;

	// An Array of GameObjects for bullets.
	private GameObject[] m_gBulletList;

    // pool size. how many bullet allowd on screen at once.
	public int m_nPoolSize;

    //--------------------------------------------------------------------------------------
    // initialization
    //--------------------------------------------------------------------------------------
    void Awake()
	{
        // initialize bullet list with size.
        m_gBulletList = new GameObject[m_nPoolSize];

        // Go through each bullet.
        for (int i = 0; i < m_nPoolSize; ++i)
		{
            // Instantiate and set active state.
            m_gBulletList[i] = Instantiate(m_gBlueprint);
			m_gBulletList[i].SetActive(false);
		}
	}

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update()
	{
        // If the mouse is pressed.
		if (Input.GetMouseButtonDown(0))
		{
            // Allocate a bullet to the pool.
			GameObject gBullet = Allocate();

            // if a valid bullet and not null.
			if (gBullet)
			{
                // Update the postion, rotation and set direction of the bullet.
                gBullet.transform.position = transform.position;
                gBullet.transform.rotation = transform.rotation;
                gBullet.GetComponent<PistolBullet>().SetDir(transform.right);
			}
		}
	}

    //--------------------------------------------------------------------------------------
    // Allocate: Allocate bullets to the pool.
    //
    // Return:
    //      GameObject: Current gameobject in the pool.
    //--------------------------------------------------------------------------------------
    GameObject Allocate()
	{
        // For each in the pool.
		for (int i = 0; i < m_nPoolSize; ++i)
		{
            // Check if active.
			if (!m_gBulletList[i].activeInHierarchy)
			{
                // Set active state.
				m_gBulletList[i].SetActive(true);

                // return the bullet.
				return m_gBulletList[i];
			}
		}

        // if all fail return null.
		return null;
	}
}
