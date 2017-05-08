using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
	public float jumpHeight = 10;

	// Update is called once per frame
	void FixedUpdate ()
    {
		Movement ();
	}

	void Movement()
	{
		transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
	}
}
