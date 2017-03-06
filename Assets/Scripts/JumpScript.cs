using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

	SpriteRenderer sr;
	LineRenderer lr;
	// Use this for initialization
	void Start () {
		//sr = GetComponent<SpriteRenderer> ();
		lr = GetComponent<LineRenderer> ();
		//lr.GetPosition ();
		//Debug.Log (lr.GetPosition(1));
 //			 Debug.Log (sr.bounds.center.x);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		Vector2 mouseposition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
//		Debug.Log(lr.GetPosition(1));
//		Debug.Log (mouseposition);
	}
}
