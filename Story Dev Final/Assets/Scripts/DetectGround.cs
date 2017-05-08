using UnityEngine;
using System.Collections;

public class DetectGround : MonoBehaviour 
{
	private Rigidbody2D playerRigidBody;
	private PlayerMovement playerMovementScript;

	// Use this for initialization
	void Start () 
	{
		playerRigidBody = GetComponentInParent<Rigidbody2D> ();
		playerMovementScript = GetComponentInParent<PlayerMovement> ();
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Floor" && Input.GetButtonDown("Jump"))
		{
			playerRigidBody.AddForce (Vector2.up * playerMovementScript.jumpHeight * Time.deltaTime);
		}
	}
}
