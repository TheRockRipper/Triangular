﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimLineController : MonoBehaviour {
	public float speed = 5f;
	public GameObject target;
	void Start () {
	}
		
	void Update () {
		Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90f;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, speed * Time.deltaTime);
		//Debug.Log ("Angle = " + angle);
		transform.position = target.transform.position;
	}
}