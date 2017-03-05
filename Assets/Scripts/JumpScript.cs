using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

	SpriteRenderer sr;
	LineRenderer lr;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		lr = GetComponent<LineRenderer> ();
		 Debug.Log (sr.bounds.center.x);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
