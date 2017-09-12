using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;

    void Awake() 
    {
        offset = transform.position - target.transform.position;
    }
	
	void Update()
    {
        float newXPosition = target.transform.position.x - offset.x;
        float newYPosition = target.transform.position.y - offset.y;

        transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);
    }	
}
