using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector3 speed = new Vector3(1,1,1);
	public Vector3 direction = new Vector3(0,0,0);

	
	void Update()
	{
		gameObject.transform.Translate (new Vector3 (speed.x * direction.x, speed.y * direction.y, speed.z * direction.z)); 

	}
	
	void FixedUpdate()
	{

	}
}
