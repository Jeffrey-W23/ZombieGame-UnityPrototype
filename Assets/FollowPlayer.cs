using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject target; //This will be your citizen
	public Vector3 distance;

	// Use this for initialization
	void Start() 
    {
		distance = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void LastUpdate()
    {
		float newXPosition = target.transform.position.x - distance.x;
		float newZPosition = target.transform.position.z - distance.z;

		transform.position = new Vector3(newXPosition, transform.position.y, newXPosition);
    }	
}
