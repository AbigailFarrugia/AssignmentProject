using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;


//code for camera to follow frog on Y axis
	void LateUpdate () 
	{
		//if frog goes up in y axis, camera goes up in y axis also until centered 
		if (target.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}

	}
}
