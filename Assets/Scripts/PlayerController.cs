using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//Player Variables
	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D triRb;

	//Aim Line Variables
	public Transform aimLine;
	private float MinZRot, MaxZRot;
	private float ZRot;

	//Jump Variables
	public float Vi = 75;
	float angle;

	void Start () {
		MinZRot = -90.0f;
		MaxZRot = 90.0f;
		ZRot = 0;

		triRb = GetComponent<Rigidbody2D> ();
	}

	void Update(){

		ZRot = -Mathf.Atan2(Input.mousePosition.x - aimLine.position.x, Input.mousePosition.y - aimLine.position.y) * (180 / Mathf.PI);
		ZRot = Mathf.Clamp(ZRot, MinZRot, MaxZRot);
		aimLine.eulerAngles = new Vector3(aimLine.eulerAngles.x, aimLine.eulerAngles.y, ZRot);

		Vector3 targetDir = Input.mousePosition - transform.position;
		angle = Vector3.Angle( targetDir, transform.right );
		Debug.Log (angle);
	}
		
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		triRb.angularVelocity = (moveHorizontal * -1) * moveSpeed;

		if (Input.GetKeyDown (KeyCode.Space)) {
			//triRb.AddForce (new Vector2(0, 1 * jumpForce),ForceMode2D.Impulse);
			Jump();
		}
	}

	void Jump(){
		float Vy, Vx;   // y,z components of the initial velocity

		Vy = Vi * Mathf.Sin(Mathf.Deg2Rad * angle);
		Vx = Vi * Mathf.Cos(Mathf.Deg2Rad * angle);

		// create the velocity vector in local space
		Vector2 localVelocity = new Vector2(Vx, Vy);

		// transform it to global vector
		Vector3 globalVelocity = transform.TransformVector(localVelocity);

		// launch the triangle by setting its initial velocity
		triRb.velocity = globalVelocity;
	}
}