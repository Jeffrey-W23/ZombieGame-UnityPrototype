using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {

	public GameObject m_gBlueprint;
	GameObject[] m_gBulletList;
	public int m_nPoolSize;

	// Use this for initialization
	void Awake()
	{
		m_gBulletList = new GameObject[m_nPoolSize];

		for (int i = 0; i < m_nPoolSize; ++i)
		{
			m_gBulletList[i] = Instantiate(m_gBlueprint);
			m_gBulletList[i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject bullet = Allocate();

			if (bullet)
			{
				bullet.transform.position = transform.position;
				bullet.transform.rotation = transform.rotation;
				bullet.GetComponent<PistolBullet>().SetDir(transform.right);
			}
		}
	}

	GameObject Allocate()
	{
		for (int i = 0; i < m_nPoolSize; ++i)
		{
			if (!m_gBulletList[i].activeInHierarchy)
			{
				m_gBulletList[i].SetActive(true);
				return m_gBulletList[i];
			}
		}

		return null;
	}
}
