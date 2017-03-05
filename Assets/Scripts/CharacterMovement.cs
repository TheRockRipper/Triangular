using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float torque;
	public float jumpForce;
	private bool isGrounded;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float direction = Input.GetAxis ("Horizontal");
		rb.angularVelocity = -direction * torque;
	}

	void OnCollisionStay2D(Collision2D collision){
		isGrounded = true;
	}

	void OnCollisionExit2D(Collision2D collision){
		isGrounded = false;
	}
		void Update(){
		//jumpCheck = Input.GetButton ("Jump");
		if (Input.GetKey(KeyCode.Space) && isGrounded){
			Debug.Log ("Inside first if");
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) {
				Debug.Log ("Inside second if");
				rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
			}

		}
	}


}
//triangleRigidbody.angularVelocity = input.getAxis("Horizontal") * torque;