using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform PlayerTransform;
	private Vector3 offset;

	void Start () 
	{
		offset = transform.position - PlayerTransform.position;
	}
		
	void LateUpdate () 
	{
		//transform.position = PlayerTransform.position + offset;
		if (PlayerTransform != null) {
			Vector3 temp = PlayerTransform.position + offset;
			//temp.x = 0f;
			//temp.y = 2.1f;
			transform.position = temp;
		}
	}
}